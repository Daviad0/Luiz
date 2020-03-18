using System;
namespace LuizApp.Models
{
    public class InstanceConnection
    {
        public string ConnectionID { get; set; }
        public int TimeLeft { get; set; }
        public int PowerUpMax { get; set; }
        public int PowerUpMin { get; set; }
        public int PowerUpCurrent { get; set; }
        public bool PowerUpEnabled { get; set; }
        public bool PowerUpShop { get; set; }
        public bool Pause { get; set; }
    }
}
