using System;
using System.Collections.Generic;

namespace DandDEasy_WEB
{
    public partial class CharacterClasses
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int ClassId { get; set; }
        public int ClassLevel { get; set; }

        public Character Character { get; set; }
        public Class Class { get; set; }
    }
}
