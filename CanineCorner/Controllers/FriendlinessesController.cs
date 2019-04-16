using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CanineCorner.Models;

namespace CanineCorner.Controllers
{
    public class FriendlinessesController : Controller
    {
        private readonly CanineCornerContext _context;

        public FriendlinessesController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Friendlinesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Friendliness.ToListAsync());
        }

        // GET: Friendlinesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friendliness = await _context.Friendliness
                .FirstOrDefaultAsync(m => m.ID == id);
            if (friendliness == null)
            {
                return NotFound();
            }

            return View(friendliness);
        }

        // GET: Friendlinesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Friendlinesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Overall,WithFamily,WithKids,OtherDogs,WithStrangers")] Friendliness friendliness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(friendliness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(friendliness);
        }

        // GET: Friendlinesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friendliness = await _context.Friendliness.FindAsync(id);
            if (friendliness == null)
            {
                return NotFound();
            }
            return View(friendliness);
        }

        // POST: Friendlinesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Overall,WithFamily,WithKids,OtherDogs,WithStrangers")] Friendliness friendliness)
        {
            if (id != friendliness.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(friendliness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FriendlinessExists(friendliness.ID))
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
            return View(friendliness);
        }

        // GET: Friendlinesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var friendliness = await _context.Friendliness
                .FirstOrDefaultAsync(m => m.ID == id);
            if (friendliness == null)
            {
                return NotFound();
            }

            return View(friendliness);
        }

        // POST: Friendlinesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var friendliness = await _context.Friendliness.FindAsync(id);
            _context.Friendliness.Remove(friendliness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FriendlinessExists(int id)
        {
            return _context.Friendliness.Any(e => e.ID == id);
        }
    }
}
