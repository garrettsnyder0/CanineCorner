﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CanineCorner.Models;

namespace CanineCorner.Controllers
{
    public class MedicalController : Controller
    {
        private readonly CanineCornerContext _context;

        public MedicalController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Medical
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medical.Where(p => p.User == 1).ToListAsync());
        }

        // GET: Medical/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical
                .FirstOrDefaultAsync(m => m.ID == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // GET: Medical/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medical/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,User,DogName,MedName,Periodicity,LastDateGiven")] Medical medical)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medical);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medical);
        }

        // GET: Medical/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical.FindAsync(id);
            if (medical == null)
            {
                return NotFound();
            }
            return View(medical);
        }

        // POST: Medical/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,User,DogName,MedName,Periodicity,LastDateGiven")] Medical medical)
        {
            if (id != medical.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medical);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicalExists(medical.ID))
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
            return View(medical);
        }

        // GET: Medical/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medical = await _context.Medical
                .FirstOrDefaultAsync(m => m.ID == id);
            if (medical == null)
            {
                return NotFound();
            }

            return View(medical);
        }

        // POST: Medical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var medical = await _context.Medical.FindAsync(id);
            _context.Medical.Remove(medical);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicalExists(int id)
        {
            return _context.Medical.Any(e => e.ID == id);
        }
    }
}
