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
    public class DogInfoController : Controller
    {
        private readonly CanineCornerContext _context;

        public DogInfoController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: DogInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.DogInfo.Where(p => p.User == 1).ToListAsync());
        }

        // GET: DogInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogInfo = await _context.DogInfo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogInfo == null)
            {
                return NotFound();
            }

            return View(dogInfo);
        }

        // GET: DogInfo/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DogInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,User,DogName,Breed,Weight,Height,DoB,TodayDate")] DogInfo dogInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dogInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dogInfo);
        }

        // GET: DogInfo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogInfo = await _context.DogInfo.FindAsync(id);
            if (dogInfo == null)
            {
                return NotFound();
            }
            return View(dogInfo);
        }

        // POST: DogInfo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,User,DogName,Breed,Weight,Height,DoB,TodayDate")] DogInfo dogInfo)
        {
            if (id != dogInfo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dogInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogInfoExists(dogInfo.ID))
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
            return View(dogInfo);
        }

        // GET: DogInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogInfo = await _context.DogInfo
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogInfo == null)
            {
                return NotFound();
            }

            return View(dogInfo);
        }

        // POST: DogInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dogInfo = await _context.DogInfo.FindAsync(id);
            _context.DogInfo.Remove(dogInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogInfoExists(int id)
        {
            return _context.DogInfo.Any(e => e.ID == id);
        }
    }
}
