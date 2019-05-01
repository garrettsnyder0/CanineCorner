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
    public class LocationsController : Controller
    {
        private readonly CanineCornerContext _context;

        public LocationsController(CanineCornerContext context)
        {
            _context = context;
        }

        // GET: Locations
        public async Task<IActionResult> Index(string SearchString = "", string SearchType = "")
        {
            if (String.IsNullOrEmpty(SearchString) && String.IsNullOrEmpty(SearchType))
            {
                return View(await _context.Location.ToListAsync());
            }
            else if (String.IsNullOrEmpty(SearchType) && !String.IsNullOrEmpty(SearchString))
            {
                int ZipSearch = Int32.Parse(SearchString);
                return View(await _context.Location.Where(p => p.ZipCode == ZipSearch).ToListAsync());
            }
            else if (String.IsNullOrEmpty(SearchString) && !String.IsNullOrEmpty(SearchType))
            {
                return View(await _context.Location.Where(p => p.LocType == SearchType).ToListAsync());
            }
            else
            {
                int ZipSearch = Int32.Parse(SearchString);
                return View(await _context.Location.Where(p => p.ZipCode == ZipSearch && p.LocType == SearchType).ToListAsync());
            }
        }

       
        public ActionResult Order(string category, Location[] locations)
        {
            switch (category) {
                case "Name":
                    return View("Index", locations.OrderBy(p => p.LocName).ToList());
                case "Type":
                    return View("Index", locations.OrderBy(p => p.LocType).ToList());
                case "Rating":
                    return View("Index", locations.OrderBy(p => p.Rating).ToList());
                default:
                    return View("Index", locations.OrderBy(p => p.ZipCode).ToList());
            }
            
        }

        // GET: Locations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.ID == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LocName,LocType,ZipCode,Rating")] Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: Locations/Edit/5
        public async Task<IActionResult> Rate(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rate(int id, [Bind("ID,LocName,LocType,ZipCode,Rating")] Location location, int oldRating)
        {
            if (id != location.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   // var oldlocation = await _context.Location.FindAsync(id);
                    location.Rating = (location.Rating + oldRating) / 2;
                    _context.Update(location);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationExists(location.ID))
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
            return View(location);
        }

        // GET: Locations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location
                .FirstOrDefaultAsync(m => m.ID == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var location = await _context.Location.FindAsync(id);
            _context.Location.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.ID == id);
        }
    }
}
