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
    public class AdaptibilitiesController : Controller
    {
        private readonly CanineCornerContext _context;

        public AdaptibilitiesController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Adaptibilities
        public async Task<IActionResult> Index()
        {
            return View(await _context.Adaptibility.ToListAsync());
        }

        // GET: Adaptibilities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adaptibility = await _context.Adaptibility
                .FirstOrDefaultAsync(m => m.ID == id);
            if (adaptibility == null)
            {
                return NotFound();
            }

            return View(adaptibility);
        }

        // GET: Adaptibilities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adaptibilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Overall,Apartment,NoviceOwners,Sensitivity,Alone,ColdWeather,HotWeather")] Adaptibility adaptibility)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adaptibility);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(adaptibility);
        }

        // GET: Adaptibilities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adaptibility = await _context.Adaptibility.FindAsync(id);
            if (adaptibility == null)
            {
                return NotFound();
            }
            return View(adaptibility);
        }

        // POST: Adaptibilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Overall,Apartment,NoviceOwners,Sensitivity,Alone,ColdWeather,HotWeather")] Adaptibility adaptibility)
        {
            if (id != adaptibility.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adaptibility);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdaptibilityExists(adaptibility.ID))
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
            return View(adaptibility);
        }

        // GET: Adaptibilities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adaptibility = await _context.Adaptibility
                .FirstOrDefaultAsync(m => m.ID == id);
            if (adaptibility == null)
            {
                return NotFound();
            }

            return View(adaptibility);
        }

        // POST: Adaptibilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adaptibility = await _context.Adaptibility.FindAsync(id);
            _context.Adaptibility.Remove(adaptibility);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdaptibilityExists(int id)
        {
            return _context.Adaptibility.Any(e => e.ID == id);
        }
    }
}
