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
    public class CharacterClassesController : Controller
    {
        private readonly DnDContext _context;

        public CharacterClassesController(DnDContext context)
        {
            _context = context;
        }

        // GET: CharacterClasses
        public async Task<IActionResult> Index()
        {
            var dnDContext = _context.CharacterClasses.Include(c => c.Character).Include(c => c.Class);
            return View(await dnDContext.ToListAsync());
        }

        // GET: CharacterClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterClasses = await _context.CharacterClasses
                .Include(c => c.Character)
                .Include(c => c.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (characterClasses == null)
            {
                return NotFound();
            }

            return View(characterClasses);
        }

        // GET: CharacterClasses/Create
        public IActionResult Create()
        {
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id");
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "ClassName");
            return View();
        }

        // POST: CharacterClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CharacterId,ClassId,ClassLevel")] CharacterClasses characterClasses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(characterClasses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", characterClasses.CharacterId);
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "ClassName", characterClasses.ClassId);
            return View(characterClasses);
        }

        // GET: CharacterClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterClasses = await _context.CharacterClasses.FindAsync(id);
            if (characterClasses == null)
            {
                return NotFound();
            }
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", characterClasses.CharacterId);
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "ClassName", characterClasses.ClassId);
            return View(characterClasses);
        }

        // POST: CharacterClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CharacterId,ClassId,ClassLevel")] CharacterClasses characterClasses)
        {
            if (id != characterClasses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(characterClasses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CharacterClassesExists(characterClasses.Id))
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
            ViewData["CharacterId"] = new SelectList(_context.Character, "Id", "Id", characterClasses.CharacterId);
            ViewData["ClassId"] = new SelectList(_context.Class, "Id", "ClassName", characterClasses.ClassId);
            return View(characterClasses);
        }

        // GET: CharacterClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var characterClasses = await _context.CharacterClasses
                .Include(c => c.Character)
                .Include(c => c.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (characterClasses == null)
            {
                return NotFound();
            }

            return View(characterClasses);
        }

        // POST: CharacterClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var characterClasses = await _context.CharacterClasses.FindAsync(id);
            _context.CharacterClasses.Remove(characterClasses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CharacterClassesExists(int id)
        {
            return _context.CharacterClasses.Any(e => e.Id == id);
        }
    }
}
