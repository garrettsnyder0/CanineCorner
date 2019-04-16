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
    public class BreedInfoController : Controller
    {
        private readonly CanineCornerContext _context;

        public BreedInfoController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: BreedInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.BreedInfo.ToListAsync());
        }

        // GET: BreedInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breedInfo = await _context.BreedInfo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (breedInfo == null)
            {
                return NotFound();
            }

            return View(breedInfo);
        }

        // GET: BreedInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BreedInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Breed,adaptability,friendliness,health,grooming,training,exercise")] BreedInfo breedInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(breedInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(breedInfo);
        }

        // GET: BreedInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breedInfo = await _context.BreedInfo.FindAsync(id);
            if (breedInfo == null)
            {
                return NotFound();
            }
            return View(breedInfo);
        }

        // POST: BreedInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Breed,adaptability,friendliness,health,grooming,training,exercise")] BreedInfo breedInfo)
        {
            if (id != breedInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(breedInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BreedInfoExists(breedInfo.ID))
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
            return View(breedInfo);
        }

        // GET: BreedInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var breedInfo = await _context.BreedInfo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (breedInfo == null)
            {
                return NotFound();
            }

            return View(breedInfo);
        }

        // POST: BreedInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var breedInfo = await _context.BreedInfo.FindAsync(id);
            _context.BreedInfo.Remove(breedInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BreedInfoExists(int id)
        {
            return _context.BreedInfo.Any(e => e.ID == id);
        }
    }
}
