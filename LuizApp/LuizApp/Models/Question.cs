using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LuizApp.Models
{
    public class Question
    {
        [Key]
        public int QuestionID { get; set; }
        public int QuizID { get; set; }
        [MaxLength(200)]
        public string QuestionName { get; set; }
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
        public int CorrectAnswer { get; set; }

        [ForeignKey("QuizID")]
        public virtual Quiz Quiz { get; set; }
    }
}
