using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Hola.Models;

namespace Hola.Models
{
    public class Question
    {
        //LanguageID
        [Column(Order = 1), Key, Required]
        public int LanguageID { get; set; }
        public virtual Language Languages { get; set; }

        //Level
        [Column(Order = 2), Key, Required]
        public int Level { get; set; }

        //QuestionID
        [Column(Order = 3), Key, Required]
        public int QuestionID { get; set; }

        //Question
        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string QuestionEnglish { get; set; }

        public string QuestionImagePath { get; set; }

        public string QuestionVoicePath { get; set; }

        //CorrectAnswer
        [Required]
        public string CorrectAnswer { get; set; }

        public string CorrectAnswerImagePath { get; set; }

        public string CorrectAnswerVoicePath { get; set; }
        
        //ChoiceA
        [Required]
        public string ChoiceA { get; set; }

        public string ChoiceAVoicePath { get; set; }

        //ChoiceB
        [Required]
        public string ChoiceB { get; set; }

        public string ChoiceBVoicePath { get; set; }

        //ChoiceC
        [Required]
        public string ChoiceC { get; set; }

        public string ChoiceCVoicePath { get; set; }

        //ChoiceD
        [Required]
        public string ChoiceD { get; set; }

        public string ChoiceDVoicePath { get; set; }
    }
}