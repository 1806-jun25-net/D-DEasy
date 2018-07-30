using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DandDEasy_WEB.Models
{
    public partial class CharacterClasses
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int ClassId { get; set; }
        public int ClassLevel { get; set; }

        [ForeignKey("CharacterId")]
        [InverseProperty("CharacterClasses")]
        public Character Character { get; set; }
        [ForeignKey("ClassId")]
        [InverseProperty("CharacterClasses")]
        public Class Class { get; set; }
    }
}
