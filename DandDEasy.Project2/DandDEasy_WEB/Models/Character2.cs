using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Models
{
    public class Character2
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? CampaignId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Background { get; set; }
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
    }
}
