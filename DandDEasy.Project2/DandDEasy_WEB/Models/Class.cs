using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DandDEasy_WEB.Models
{
    public partial class Class
    {
        public Class()
        {
            CharacterClasses = new HashSet<CharacterClasses>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string ClassName { get; set; }
        [Required]
        [StringLength(10)]
        public string HitDice { get; set; }

        [InverseProperty("Class")]
        public ICollection<CharacterClasses> CharacterClasses { get; set; }
    }
}
