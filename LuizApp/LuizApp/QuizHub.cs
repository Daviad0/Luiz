using LuizApp.Data;
using LuizApp.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class QuizHub : Hub
    {
        private static int Timeleft = 0;
        private readonly QuizContext db;
        private static Dictionary<string,string> Instances = new System.Collections.Generic.Dictionary<string, string>();
        private static Dictionary<string,GameServerConnection> GameServer = new System.Collections.Generic.Dictionary<string, GameServerConnection>();
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
                    
                }
                else
                {
                    GameServer[UserID].ConnectionId = Context.ConnectionId;
                }
                Clients.Client(Context.ConnectionId).SendAsync("signedIn");
                Clients.Client(Instances.Where(p => p.Key == GameKey).FirstOrDefault().Value).SendAsync("newUserLogin", UserName);
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
            foreach (var item in GameServer.Keys)
            {
                
                if(GameServer[item].LastAnswer == CorrectAnswer)
                {
                    GameServer[item].Points += 1000;
                    GameServer[item].Points += 50 * Timeleft;
                    GameServer[item].Points += 50 * GameServer[item].Streak;
                    GameServer[item].Streak++;
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
            Clients.All.SendAsync("questionResults", numcorrect, numwrong, num1, num2, num3, num4);
        }
        public void ViewToggle(bool ReviewScore)
        {
            var ClientLeaderboard = GameServer.ToList();
            foreach (var item in ClientLeaderboard.OrderByDescending(c => c.Value.Points))
            {
                Clients.Client(item.Value.ConnectionId).SendAsync("clientScoreSend", item.Value.Points, item.Value.Streak);
            }
            Clients.All.SendAsync("toggleScore", ReviewScore);
            
        }
        public void GetLeaderboard()
        {
            int i = 0;
            var PreviousUser = new GameServerConnection();
            var TopTen = new List<GameServerConnection>();
            var Behind = false;
            foreach(var item in GameServer.OrderByDescending(c => c.Value.Points).ThenByDescending(c => c.Value.Streak).ThenBy(c => c.Value.UserName))
            {
                i++;
                if(i <= 10)
                {
                    TopTen.Add(item.Value);
                }
                Clients.Client(item.Value.ConnectionId).SendAsync("placement", i, Behind, PreviousUser);
                PreviousUser = item.Value;
                Behind = true;
            }
            Clients.All.SendAsync("sendLeaderboard", TopTen);
        }
        public void InstanceCreate(string GeneratedKey)
        {
            if (!Instances.ContainsKey(GeneratedKey))
            {
                Instances.Add(GeneratedKey, Context.ConnectionId);
                Clients.Client(Context.ConnectionId).SendAsync("gameCreated", true, GeneratedKey);
            }
            else
            {
                Clients.Client(Context.ConnectionId).SendAsync("gameCreated", false, GeneratedKey);
            }
        }
        public void LoadQuestion(int QuestionID)
        {
            var QuestionToLoad = (from q in db.Questions where q.QuestionID == QuestionID select q).FirstOrDefault();
            Clients.All.SendAsync("questionLoaded", QuestionToLoad);
        }
        //MASTER > CLIENT
        public void TimeLeft(int seconds)
        {
            Clients.All.SendAsync("questionTimeLeft", seconds);
        }
        public void NextQuestion()
        {
            Clients.All.SendAsync("nextQuestion");
        }
    }
}