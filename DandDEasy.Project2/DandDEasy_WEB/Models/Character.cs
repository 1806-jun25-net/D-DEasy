using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DandDEasy_WEB.Models
{
    public partial class Character
    {
        public Character()
        {
            CharacterClasses = new HashSet<CharacterClasses>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? CampaignId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Race { get; set; }
        [StringLength(50)]
        public string Background { get; set; }
        [StringLength(20)]
        public string Alignment { get; set; }
        public int? Experience { get; set; }
        public int? Strength { get; set; }
        public int? Dexterity { get; set; }
        public int? Constitution { get; set; }
        public int? Intelligence { get; set; }
        public int? Wisdom { get; set; }
        public int? Charisma { get; set; }
        public int? HitPoints { get; set; }
        public int? ArmorClass { get; set; }

        [ForeignKey("CampaignId")]
        [InverseProperty("Character")]
        public Campaign Campaign { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Character")]
        public User User { get; set; }
        [InverseProperty("Character")]
        public CampaignGraveyard CampaignGraveyard { get; set; }
        [InverseProperty("Character")]
        public ICollection<CharacterClasses> CharacterClasses { get; set; }
    }
}
