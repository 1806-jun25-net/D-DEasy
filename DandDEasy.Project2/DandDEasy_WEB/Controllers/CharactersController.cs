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
    public class CharactersController : Controller
    {
        // GET: Characters
        public async Task<IActionResult> Index()
        {
           
            return View();
        }

        // GET: Characters/Details/5
        public async Task<IActionResult> Details(int? id)
        {


            return View();
        }

        // GET: Characters/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Characters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CampaignId,CreationDate,Name,Race,Background,Alignment,Experience,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,HitPoints,ArmorClass")] Character character)
        {
            //if (ModelState.IsValid)
            //{
            //    _context.Add(character);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", character.CampaignId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", character.UserId);
            return View();
        }

        // GET: Characters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var character = await _context.Character.FindAsync(id);
            //if (character == null)
            //{
            //    return NotFound();
            //}
            //ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", character.CampaignId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", character.UserId);
            return View();
        }

        // POST: Characters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,CampaignId,CreationDate,Name,Race,Background,Alignment,Experience,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,HitPoints,ArmorClass")] Character character)
        {
            //if (id != character.Id)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(character);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!CharacterExists(character.Id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["CampaignId"] = new SelectList(_context.Campaign, "Id", "Password", character.CampaignId);
            //ViewData["UserId"] = new SelectList(_context.User, "Id", "Email", character.UserId);
            return View();
        }

        // GET: Characters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var character = await _context.Character
            //    .Include(c => c.Campaign)
            //    .Include(c => c.User)
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (character == null)
            //{
            //    return NotFound();
            //}

            return View();
        }

        // POST: Characters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var character = await _context.Character.FindAsync(id);
            //_context.Character.Remove(character);
            //await _context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));
            return View();
        }

        //private bool CharacterExists(int id)
        //{
        //    //return _context.Character.Any(e => e.Id == id);

        //}
    }
}
