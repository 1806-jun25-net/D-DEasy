using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DandDEasy_WEB.Models
{
    public partial class Campaign
    {
        public Campaign()
        {
            CampaignGraveyard = new HashSet<CampaignGraveyard>();
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        public int DungeonMasterId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreationDate { get; set; }

        [ForeignKey("DungeonMasterId")]
        [InverseProperty("Campaign")]
        public User DungeonMaster { get; set; }
        [InverseProperty("Campaign")]
        public ICollection<CampaignGraveyard> CampaignGraveyard { get; set; }
        [InverseProperty("Campaign")]
        public ICollection<Character> Character { get; set; }
    }
}
