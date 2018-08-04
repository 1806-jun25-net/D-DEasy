using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DandDEasy.Services;
using Microsoft.AspNetCore.Authorization;
using DandDEasy.Services.Repo;

namespace DandDEasy.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CampaignsController : ControllerBase
    {
        private readonly DnDEasyContext _context;
         public CharacterRepo Repo{ get; set; }
        public UserRepo URepo { get; set; }
        public CampaignRepo CRepo { get; set; }

        public CampaignsController(DnDEasyContext context, UserRepo urepo, CampaignRepo crepo, CharacterRepo repo)
        {
            _context = context;
            URepo = urepo;
            CRepo = crepo;
            Repo = repo;
        }

        // GET: api/Campaigns
        [HttpGet]
        public IEnumerable<Campaign> GetCampaign()
        {
            return _context.Campaign;
        }

        // GET: api/Campaigns/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCampaign([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var campaign = await _context.Campaign.FindAsync(id);

            if (campaign == null)
            {
                return NotFound();
            }

            return Ok(campaign);
        }

        // PUT: api/Campaigns/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCampaign([FromRoute] int id, [FromBody] Campaign campaign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != campaign.Id)
            {
                return BadRequest();
            }

            _context.Entry(campaign).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CampaignExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Campaigns
        [HttpPost]
        public void PostCampaign(Campaign campaign)
        {
            string name = "Wesley";
            var user = URepo.GetUsertable().FirstOrDefault(x => x.FirstName == name);
            var userid = user.Id;

            campaign.DungeonMasterId = user.Id;

            _context.Campaign.Add(campaign);
            _context.SaveChanges();
        }

        // DELETE: api/Campaigns/5
        [HttpPost("{elid}")]
        public void DeleteCampaign(int elid)
        {
            CRepo.DeleteCampaign(elid);
        }

        private bool CampaignExists(int id)
        {
            return _context.Campaign.Any(e => e.Id == id);
        }
    }
}