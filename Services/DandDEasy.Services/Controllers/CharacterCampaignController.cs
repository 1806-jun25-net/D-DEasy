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
        public CharacterRepo Repo{ get; set; }
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
        public ActionResult<CharacterCampaign> MainPage() // get here after the log in authentication is succesfull
        {
            string name = "Wesley";
            var user = URepo.GetUsertable().FirstOrDefault(x => x.FirstName == name); // Get all user
            var userid = user.Id; // get User ID
            var character = Repo.GetCharactertable().Where(x => x.UserId == userid).ToList(); // Get all Character from the user
            var campaign = CRepo.GetCampaignTable().ToList(); // Get all campaign

            CharacterCampaign charac = new CharacterCampaign
            {
               // CHA = character,
                //CAM = campaign
            };

            return charac;
        }
    }
}