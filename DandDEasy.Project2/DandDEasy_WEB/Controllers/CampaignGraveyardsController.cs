using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DandDEasy_WEB.Models;

namespace DandDEasy_WEB.Controllers
{
    public class CampaignGraveyardsController : Controller
    {
        private readonly DnDContext _context;

        public CampaignGraveyardsController(DnDContext context)
        {
            _context = context;
        }

        // GET: CampaignGraveyards
        public async Task<IActionResult> Index()
        {
            var dnDContext = _context.CampaignGraveyard.Include(c => c.Campaign).Include(c => c.Character);
            return View(await dnDContext.ToListAsync());
        }

        // GET: CampaignGraveyards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignGraveyard = await _context.CampaignGraveyard
                .Include(c => c.Campaign)
                .Include(c => c.Character)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaignGraveyard == null)
            {
                return NotFound();
            }

            return View(campaignGraveyard);
        }

        // GET: CampaignGraveyards/Create
        public IActionResult Create()
        {
            ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password");
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id");
            return View();
        }

        // POST: CampaignGraveyards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CampaignId,CharacterId")] CampaignGraveyard campaignGraveyard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(campaignGraveyard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", campaignGraveyard.CampaignId);
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", campaignGraveyard.CharacterId);
            return View(campaignGraveyard);
        }

        // GET: CampaignGraveyards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignGraveyard = await _context.CampaignGraveyard.FindAsync(id);
            if (campaignGraveyard == null)
            {
                return NotFound();
            }
            ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", campaignGraveyard.CampaignId);
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", campaignGraveyard.CharacterId);
            return View(campaignGraveyard);
        }

        // POST: CampaignGraveyards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CampaignId,CharacterId")] CampaignGraveyard campaignGraveyard)
        {
            if (id != campaignGraveyard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(campaignGraveyard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CampaignGraveyardExists(campaignGraveyard.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", campaignGraveyard.CampaignId);
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", campaignGraveyard.CharacterId);
            return View(campaignGraveyard);
        }

        // GET: CampaignGraveyards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignGraveyard = await _context.CampaignGraveyard
                .Include(c => c.Campaign)
                .Include(c => c.Character)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (campaignGraveyard == null)
            {
                return NotFound();
            }

            return View(campaignGraveyard);
        }

        // POST: CampaignGraveyards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var campaignGraveyard = await _context.CampaignGraveyard.FindAsync(id);
            _context.CampaignGraveyard.Remove(campaignGraveyard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CampaignGraveyardExists(int id)
        {
            return _context.CampaignGraveyard.Any(e => e.Id == id);
        }
    }
}
