using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DandDEasy.Services.Models;
using DandDEasy.Services.Repo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DandDEasy.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CharacterCampaignController : ControllerBase
    {
        // private readonly DnDEasyContext _context;
        public CharacterRepo Repo { get; set; }
        public UserRepo URepo { get; set; }
        public CampaignRepo CRepo { get; set; }

        public CharacterCampaignController(CharacterRepo repo, UserRepo urepo, CampaignRepo crepo)
        {
            // _context = context;
            Repo = repo;
            URepo = urepo;
            CRepo = crepo;
        }


        [HttpGet]
        //[Authorize]
        public ActionResult<CharacterCampaign> MainPage(User credentials) // get here after the log in authentication is succesfull
        {
            var credentials2 = "Wesley";
            var user = URepo.GetUsertable().FirstOrDefault(x => x.FirstName == credentials2/*.FirstName && x.Password == credentials2.Password*/); // Get all user
            var userid = user.Id; // get User ID
            var character = Repo.GetCharactertable().Where(x => x.UserId == userid).ToList(); // Get all Character from the user
            var campaign = CRepo.GetCampaignTable().ToList(); // Get all campaign

            //List<Character2> loschara = new List<Character2>();

            IEnumerable<Character2> character2 = character.Select(x => new Character2
            {
                Id = x.Id,
                Name = x.Name,
                Alignment = x.Alignment,
                ArmorClass = x.ArmorClass,
                Background = x.Background,
                CampaignId = x.CampaignId,
                Charisma = x.Charisma,
                Constitution = x.Constitution,
                CreationDate = x.CreationDate,
                Dexterity = x.Dexterity,
                Experience = x.Experience,
                HitPoints = x.HitPoints,
                Intelligence = x.Intelligence,
                Race = x.Race,
                Strength = x.Strength,
                Wisdom = x.Wisdom
            });

            IEnumerable<Campaign2> campaign2 = campaign.Select(x => new Campaign2
            {
                Id = x.Id,
                DungeonMasterId = x.DungeonMasterId,
                Title = x.Title,
                Password = x.Password,
                CreationDate = x.CreationDate
            });

            //character2.Add(character.Select(x => x.ArmorClass);


            CharacterCampaign charac = new CharacterCampaign
            {
                CHA = character2,
                CAM = campaign2
            };

            return charac;
        }
    }
}