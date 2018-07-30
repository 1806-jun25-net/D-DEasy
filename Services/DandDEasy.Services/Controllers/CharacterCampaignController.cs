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

        public CharacterCampaignController(CharacterRepo repo, UserRepo urepo)
        {
            // _context = context;
            Repo = repo;
            urepo = urepo;

        }

        //[HttpGet]
        //[AllowAnonymous]
        //public IActionResult Index(string name, string password) // get here after the log in authentication is succesfull
        //{

        //    var user = URepo.GetUsertable().FirstOrDefault(x => x.FirstName == name && x.Password == password);
        //    var userid = user.Id;
        //    var character = Repo.GetCharactertable().Where(x => x.UserId == userid);
            
        //    CharacterCampaign charac = new CharacterCampaign
        //    {
        //        CHA = character
                
        //    };

        //    return charac;
        //}
    }
}