﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Models
{
    public class CharacterCampaign
    {
        public IEnumerable<Character2> CHA { get; set; }
        public IEnumerable<Campaign2> CAM { get; set; }
    }
}
