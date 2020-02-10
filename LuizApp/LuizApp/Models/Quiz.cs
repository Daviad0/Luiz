using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuizApp.Models
{
    public class Quiz
    {
        [Key]
        public int QuizID { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public bool PCCS { get; set; }

        public ICollection<Question> Questions { get; set; }
    }
}
