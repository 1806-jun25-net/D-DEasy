using System;
using System.Collections.Generic;

namespace DandDEasy_WEB
{
    public partial class Class
    {
        public Class()
        {
            CharacterClasses = new HashSet<CharacterClasses>();
        }

        public int Id { get; set; }
        public string ClassName { get; set; }
        public string HitDice { get; set; }

        public ICollection<CharacterClasses> CharacterClasses { get; set; }
    }
}
