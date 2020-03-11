using LuizApp.Data;
using LuizApp.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class QuizHub : Hub
    {
        private static int Timeleft = 0;
        private readonly QuizContext db;
        private static Dictionary<string,InstanceConnection> Instances = new System.Collections.Generic.Dictionary<string, InstanceConnection>();
        private static Dictionary<string,GameServerConnection> GameServer = new System.Collections.Generic.Dictionary<string, GameServerConnection>();
        private static Dictionary<string, PowerUpLog> PowerUps = new Dictionary<string, PowerUpLog>();
        public QuizHub(QuizContext db)
        {
            this.db = db;
        }
        //CLIENT > SERVER
        public void ConnectToServer(string UserID, string UserName, bool Connected, string GameKey)
        {
            if (Connected)
            {
                
                if (!GameServer.ContainsKey(UserID))
                {
                    GameServerConnection newUser = new GameServerConnection();
                    newUser.ConnectionId = Context.ConnectionId;
                    newUser.Points = 0;
                    newUser.LastAnswer = 0;
                    newUser.Locked = false;
                    newUser.TimeSubmitted = 0;
                    newUser.Streak = 0;
                    newUser.UserName = UserName;
                    newUser.GameKey = GameKey;
                    GameServer.Add(UserID, newUser);
                    PowerUpLog powerUpLog = new PowerUpLog();
                    powerUpLog.PowerPoints = 0;
                    powerUpLog.SaveMe = 0;
                    powerUpLog.TimeMax = 0;
                    PowerUps.Add(UserID,powerUpLog);
                    Groups.AddToGroupAsync(Context.ConnectionId, GameKey);
                }
                else
                {
                    GameServer[UserID].ConnectionId = Context.ConnectionId;
                }
                Clients.Client(Context.ConnectionId).SendAsync("signedIn");
                Clients.Client(Instances.Where(p => p.Key == GameKey).FirstOrDefault().Value.ConnectionID).SendAsync("newUserLogin", UserName);
            }
        }
        public void AnswerQuestion(string UserID, int Answer)
        {
            if(Timeleft >= 0)
            {
                GameServer[UserID].LastAnswer = Answer;
                GameServer[UserID].TimeSubmitted = Timeleft;
            }
            
        }
        public void PowerUp(string UserID, int Placement)
        {
            if(Placement < 6 && Placement < GameServer.Count)
            {
                var Test = GameServer.ToList();
                var Top5 = Test.OrderByDescending(a => a.Value.Points).Take(5).ToList();
                GameServer[Top5[Placement - 1].Key].Locked = true;
            }
        }
        //MASTER > SERVER
        public void CheckAnswers(int CorrectAnswer)
        {
            int numcorrect = 0;
            int numwrong = 0;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            var GameToSelect = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            foreach (var item in GameServer.Keys)
            {
                if(GameServer[item].GameKey == GameToSelect.Key) { 
                    if(GameServer[item].LastAnswer == CorrectAnswer)
                    {
                        GameServer[item].Points += 1000;
                        GameServer[item].Points += 7 * GameToSelect.Value.TimeLeft;
                        GameServer[item].Points += 40 * GameServer[item].Streak;
                        GameServer[item].Streak++;
                        PowerUps[item].PowerPoints += (int)Math.Floor(GameToSelect.Value.TimeLeft * (1 + (.1 * GameServer[item].Streak)));
                        Clients.Client(GameServer[item].ConnectionId).SendAsync("answerStatus", GameServer[item].Points, true, GameServer[item].Streak);
                        numcorrect++;
                    }
                    else
                    {
                        GameServer[item].Streak = 0;
                        Clients.Client(GameServer[item].ConnectionId).SendAsync("answerStatus", GameServer[item].Points, false, GameServer[item].Streak);
                        numwrong++;
                    }
                    if(GameServer[item].LastAnswer != 0)
                    {
                        if(GameServer[item].LastAnswer == 1)
                        {
                            num1++;
                        }else if(GameServer[item].LastAnswer == 2)
                        {
                            num2++;
                        }
                        else if (GameServer[item].LastAnswer == 3)
                        {
                            num3++;
                        }
                        else if (GameServer[item].LastAnswer == 4)
                        {
                            num4++;
                        }
                    }
                    GameServer[item].LastAnswer = 0;
                }
            }
            Clients.Client(Context.ConnectionId).SendAsync("questionResults", numcorrect, numwrong, num1, num2, num3, num4);
        }
        public void ViewToggle(bool ReviewScore)
        {
            var SelectedGame = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            var ClientLeaderboard = GameServer.ToList();
            foreach (var item in ClientLeaderboard.OrderByDescending(c => c.Value.Points).Where(c => c.Value.GameKey == SelectedGame.Key))
            {
                Clients.Client(item.Value.ConnectionId).SendAsync("clientScoreSend", item.Value.Points, item.Value.Streak);
                Clients.Client(item.Value.ConnectionId).SendAsync("clientPower", PowerUps[item.Key].PowerPoints);
            }
            Clients.Group(SelectedGame.Value.ConnectionID).SendAsync("toggleScore");

        }
        public void GetLeaderboard()
        {
            var SelectedGame = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            int i = 0;
            var PreviousUser = new GameServerConnection();
            var TopTen = new List<GameServerConnection>();
            var Behind = false;
            var PowerPoints = 0;
            foreach(var item in GameServer.Where(c => c.Value.GameKey == SelectedGame.Key).OrderByDescending(c => c.Value.Points).ThenByDescending(c => c.Value.Streak).ThenBy(c => c.Value.UserName))
            {
                PowerPoints = PowerPoints + PowerUps[item.Key].PowerPoints;
                i++;
                if(i <= 10)
                {
                    TopTen.Add(item.Value);
                }
                Clients.Client(item.Value.ConnectionId).SendAsync("placement", i, Behind, PreviousUser);
                PreviousUser = item.Value;
                Behind = true;
            }
            Clients.Client(Context.ConnectionId).SendAsync("sendLeaderboard", TopTen, PowerPoints);
        }
        public void InstanceCreate(string GeneratedKey)
        {
            if (!Instances.ContainsKey(GeneratedKey))
            {
                var InstanceToCreate = new InstanceConnection();
                InstanceToCreate.ConnectionID = Context.ConnectionId;
                InstanceToCreate.Pause = false;
                InstanceToCreate.TimeLeft = 0;
                Instances.Add(GeneratedKey, InstanceToCreate);
                Clients.Client(Context.ConnectionId).SendAsync("gameCreated", true, GeneratedKey);
            }
            else
            {
                Clients.Client(Context.ConnectionId).SendAsync("gameCreated", false, GeneratedKey);
            }
        }
        public void LoadQuestion(int QuestionID)
        {
            var SelectedGame = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            var QuestionToLoad = (from q in db.Questions where q.QuestionID == QuestionID select q).FirstOrDefault();
            Clients.Group(SelectedGame.Key).SendAsync("questionLoaded");
            Clients.Client(Context.ConnectionId).SendAsync("questionLoaded", QuestionToLoad);


        }
        public void SetTimer(int TimeLeftGiven)
        {
            var SelectedGame = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            SelectedGame.Value.TimeLeft = TimeLeftGiven;
        }
        //MASTER > CLIENT
        public void TimeLeft(int seconds)
        {
            Clients.All.SendAsync("questionTimeLeft", seconds);
        }
        public void NextQuestion()
        {
            var SelectedGame = Instances.Where(u => u.Value.ConnectionID == Context.ConnectionId).FirstOrDefault();
            Clients.Group(SelectedGame.Key).SendAsync("nextQuestion");
        }
    }
}