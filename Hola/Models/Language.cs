using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hola.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Icon { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public virtual ICollection<Word> Words { get; set; }
    }
}