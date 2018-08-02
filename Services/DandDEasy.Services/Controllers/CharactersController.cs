using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DandDEasy.Services;
using DandDEasy.Services.Repo;
using DandDEasy.Services.Models;

namespace DandDEasy.Services.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        //private readonly DnDEasyContext Repo;
        public CharacterRepo Repo { get; set; }

        public CharactersController(CharacterRepo repo)
        {
            // _context = context;
            Repo = repo;
        }

        //// GET: Characters
        //public async Task<IActionResult> Index()
        //{
        //    var dnDEasyContext = Repo.Character.Include(c => c.Campaign).Include(c => c.User);
        //    return View(await dnDEasyContext.ToListAsync());
        //}

        // GET: Characters/Details/5
        [HttpGet("{id}")]
        public Character2 Details(int id) // works if hardcode id = 1
        {
            Character2 thecharacter = Repo.GetCharactertByID(id);
            return thecharacter;
        }

        //// GET: Characters/Create
        //public IActionResult Create()
        //{
        //    ViewData["CampaignId"] = new SelectList(Repo.Campaign, "Id", "Password");
        //    ViewData["UserId"] = new SelectList(Repo.User, "Id", "Email");
        //    return View();
        //}

        //// POST: Characters/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,UserId,CampaignId,CreationDate,Name,Race,Background,Alignment,Experience,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,HitPoints,ArmorClass")] Character character)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Repo.Add(character);
        //        await Repo.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CampaignId"] = new SelectList(Repo.Campaign, "Id", "Password", character.CampaignId);
        //    ViewData["UserId"] = new SelectList(Repo.User, "Id", "Email", character.UserId);
        //    return View(character);
        //}

        //// GET: Characters/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var character = await Repo.Character.FindAsync(id);
        //    if (character == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["CampaignId"] = new SelectList(Repo.Campaign, "Id", "Password", character.CampaignId);
        //    ViewData["UserId"] = new SelectList(Repo.User, "Id", "Email", character.UserId);
        //    return View(character);
        //}

        //// POST: Characters/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CampaignId,CreationDate,Name,Race,Background,Alignment,Experience,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,HitPoints,ArmorClass")] Character character)
        //{
        //    if (id != character.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            Repo.Update(character);
        //            await Repo.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CharacterExists(character.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CampaignId"] = new SelectList(Repo.Campaign, "Id", "Password", character.CampaignId);
        //    ViewData["UserId"] = new SelectList(Repo.User, "Id", "Email", character.UserId);
        //    return View(character);
        //}

        //// GET: Characters/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var character = await Repo.Character
        //        .Include(c => c.Campaign)
        //        .Include(c => c.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (character == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(character);
        //}

        //// POST: Characters/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var character = await Repo.Character.FindAsync(id);
        //    Repo.Character.Remove(character);
        //    await Repo.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool CharacterExists(int id)
        //{
        //    return Repo.Character.Any(e => e.Id == id);
        //}
    }
}
