using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Models
{
    public class CharacterCampaign
    {
        public IEnumerable<Character> CHA { get; set; }
        public IEnumerable<Campaign> CAM { get; set; }
    }
}
