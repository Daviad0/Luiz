using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuizApp.Models
{
    public class GameServerConnection
    {
        public string ConnectionId { get; set; }
        public string UserName { get; set; }
        public int Points { get; set; }
        public int LastAnswer { get; set; }
        public int TimeSubmitted { get; set; }
        public int Streak { get; set; }
        public bool Locked { get; set; }

    }
}
