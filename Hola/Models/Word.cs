using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hola.Models
{
    public class Word
    {
        //LanguageID
        [Key, Column(Order = 1)]
        public int LanguageID { get; set; }
        public virtual Language Language { get; set; }

        //Level
        [Key, Column(Order = 2)]
        public int Level { get; set; }

        //WordID
        [Key, Column(Order = 3)]
        public int WordID { get; set; }

        //WordText
        [Required]
        public string WordText { get; set; }

        //WordEnglish
        [Required]
        public string WordEnglish{ get; set; }

        //ImagePath
        public string ImagePath { get; set; }

        //VoicePath
        public string VoicePath { get; set; }
    }
}