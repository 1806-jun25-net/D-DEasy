using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DandDEasy_WEB.Models
{
    public partial class CampaignGraveyard
    {
        public int Id { get; set; }
        public int? CampaignId { get; set; }
        public int? CharacterId { get; set; }

        [ForeignKey("CampaignId")]
        [InverseProperty("CampaignGraveyard")]
        public Campaign Campaign { get; set; }
        [ForeignKey("CharacterId")]
        [InverseProperty("CampaignGraveyard")]
        public Character Character { get; set; }
    }
}
