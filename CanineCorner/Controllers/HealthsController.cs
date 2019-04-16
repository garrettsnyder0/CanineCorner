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
    public class HealthsController : Controller
    {
        private readonly CanineCornerContext _context;

        public HealthsController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Healths
        public async Task<IActionResult> Index()
        {
            return View(await _context.Health.ToListAsync());
        }

        // GET: Healths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Health
                .FirstOrDefaultAsync(m => m.ID == id);
            if (health == null)
            {
                return NotFound();
            }

            return View(health);
        }

        // GET: Healths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Healths/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Overall,General,WeightGain,Size")] Health health)
        {
            if (ModelState.IsValid)
            {
                _context.Add(health);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(health);
        }

        // GET: Healths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Health.FindAsync(id);
            if (health == null)
            {
                return NotFound();
            }
            return View(health);
        }

        // POST: Healths/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Overall,General,WeightGain,Size")] Health health)
        {
            if (id != health.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(health);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HealthExists(health.ID))
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
            return View(health);
        }

        // GET: Healths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var health = await _context.Health
                .FirstOrDefaultAsync(m => m.ID == id);
            if (health == null)
            {
                return NotFound();
            }

            return View(health);
        }

        // POST: Healths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var health = await _context.Health.FindAsync(id);
            _context.Health.Remove(health);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HealthExists(int id)
        {
            return _context.Health.Any(e => e.ID == id);
        }
    }
}
