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
    public class GroomingsController : Controller
    {
        private readonly CanineCornerContext _context;

        public GroomingsController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Groomings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Grooming.ToListAsync());
        }

        // GET: Groomings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grooming = await _context.Grooming
                .FirstOrDefaultAsync(m => m.ID == id);
            if (grooming == null)
            {
                return NotFound();
            }

            return View(grooming);
        }

        // GET: Groomings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Groomings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Overall,Shedding,Drool,Easiness")] Grooming grooming)
        {
            if (ModelState.IsValid)
            {
                _context.Add(grooming);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(grooming);
        }

        // GET: Groomings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grooming = await _context.Grooming.FindAsync(id);
            if (grooming == null)
            {
                return NotFound();
            }
            return View(grooming);
        }

        // POST: Groomings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Overall,Shedding,Drool,Easiness")] Grooming grooming)
        {
            if (id != grooming.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grooming);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GroomingExists(grooming.ID))
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
            return View(grooming);
        }

        // GET: Groomings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grooming = await _context.Grooming
                .FirstOrDefaultAsync(m => m.ID == id);
            if (grooming == null)
            {
                return NotFound();
            }

            return View(grooming);
        }

        // POST: Groomings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grooming = await _context.Grooming.FindAsync(id);
            _context.Grooming.Remove(grooming);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GroomingExists(int id)
        {
            return _context.Grooming.Any(e => e.ID == id);
        }
    }
}
