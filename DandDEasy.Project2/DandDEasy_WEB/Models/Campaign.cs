using System;
using System.Collections.Generic;

namespace DandDEasy_WEB
{
    public partial class Campaign
    {
        public Campaign()
        {
            CampaignGraveyard = new HashSet<CampaignGraveyard>();
            Character = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public int DungeonMasterId { get; set; }
        public DateTime? CreationDate { get; set; }

        public User DungeonMaster { get; set; }
        public ICollection<CampaignGraveyard> CampaignGraveyard { get; set; }
        public ICollection<Character> Character { get; set; }
    }
}
