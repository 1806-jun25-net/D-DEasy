using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DandDEasy.Services.Models
{
    public class Campaign2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Password { get; set; }
        public int DungeonMasterId { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}
