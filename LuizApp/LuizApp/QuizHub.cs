    using LuizApp.Models;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class QuizHub : Hub
    {
        private static int Timeleft;
        private static Dictionary<string,GameServerConnection> GameServer = new System.Collections.Generic.Dictionary<string, GameServerConnection>();
        //CLIENT > SERVER
        public void ConnectToServer(string UserID, string UserName, bool Connected)
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
                    GameServer.Add(UserID, newUser);
                }
                else
                {
                    GameServer[UserID].ConnectionId = Context.ConnectionId;
                }
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
            foreach(var item in GameServer.Keys)
            {
                if(GameServer[item].LastAnswer == CorrectAnswer)
                {
                    GameServer[item].Points += 1000;
                    GameServer[item].Points += 50 * Timeleft;
                    GameServer[item].Points += 50 * GameServer[item].Streak;
                    GameServer[item].Streak++;
                    Clients.Client(GameServer[item].ConnectionId).SendAsync("answerStatus", GameServer[item].Points, true, GameServer[item].Streak);
                }
                else
                {
                    GameServer[item].Streak = 0;
                    Clients.Client(GameServer[item].ConnectionId).SendAsync("answerStatus", GameServer[item].Points, false, GameServer[item].Streak);
                }
                GameServer[item].LastAnswer = 0;
            }
        }
        public void ScoreToggle(bool ReviewScore)
        {
            var ClientLeaderboard = GameServer.ToList();
            foreach (var item in ClientLeaderboard.OrderByDescending(c => c.Value.Points))
            {
                Clients.Client(item.Value.ConnectionId).SendAsync("clientScoreSend", item.Value.Points, item.Value.Streak)
            }
            Clients.All.SendAsync("toggleScore", ReviewScore);
            
        }
    }
}