using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hola.Models
{
    public class Counter
    {
        public int WordNum { get; set; }
        public int LanguageSelected { get; set; }
        public int LevelSelected { get; set; }
        public bool IsLevelDone { get; set; } = false;
    }
}