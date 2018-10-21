using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hola.Models
{
    public class User_Words
    {
        #region Composite PK
        //ApplicationUserID PK FK
        [Key, Column(Order = 0, TypeName ="NVARCHAR"), StringLength(128), ForeignKey("ApplicationUser")]
        public string ApplicationUserID { get; set; }
        
        ////LanguageID
        [Key, Column(Order = 1)]
        public int LanguageID { get; set; }

        ////LevelID
        [Key, Column(Order = 2)]
        public int Level { get; set; }

        [Key, Column(Order = 3)]
        public int WordID { get; set; }


        //public virtual Language Language { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Word Word { get; set; }
        #endregion

        //Mastery
        [DefaultValue(-1)]
        [Column(Order = 4)]
        public int Mastery { get; set; }

        //LastVisited
        [Column(TypeName = "Date", Order = 5)]
        public DateTime? LastVisited { get; set; } = DateTime.Now;
    }
}