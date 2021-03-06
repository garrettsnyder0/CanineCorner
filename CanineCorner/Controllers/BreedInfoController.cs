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

        public async Task<IActionResult> Filter(int adaptibility, int exercise, int friendliness, int grooming, int health, int training)
        {
            if (adaptibility == 0 && exercise == 0 && friendliness == 0 && grooming == 0 && health == 0 && training == 0)
            {
                return View("Index", await _context.BreedInfo.ToListAsync());
            }
            
            var query = from BreedInfo in _context.BreedInfo select BreedInfo;
            if(adaptibility != 0)
            {
                query = query.Where(p => p.adaptability == adaptibility);
            }
            if (exercise != 0)
            {
                //if(searchString.Length != 0)
                //{
                //    searchString += "&&";
                //}
                query = query.Where(p => p.exercise == exercise);
            }
            if (friendliness != 0)
            {
                //if (searchString.Length != 0)
                //{
                //    searchString += "&&";
                //}
                query = query.Where(p => p.friendliness == friendliness);
            }
            if (grooming != 0)
            {
                //if (searchString.Length != 0)
                //{
                //    searchString += "&&";
                //}
                query = query.Where(p => p.grooming == grooming);
            }
            if (health != 0)
            {
                //if (searchString.Length != 0)
                //{
                //    searchString += "&&";
                //}
                query = query.Where(p => p.health == health);
            }
            if (training != 0)
            {
                //if (searchString.Length != 0)
                //{
                //    searchString += "&&";
                //}
                query = query.Where(p => p.training == training); 
            }

            return View("Index", await query.ToListAsync());

        }

        // GET: BreedInfo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var breed = await _context.BreedInfo.FirstOrDefaultAsync(m => m.ID == id);
            FullBreedStats breedInfo = new FullBreedStats();
            breedInfo.Breed = breed.Breed;
            breedInfo.Adaptibility = await _context.Adaptibility.FirstOrDefaultAsync(m => m.ID == id);
            breedInfo.Exercise = await _context.Exercise.FirstOrDefaultAsync(m => m.ID == id);
            breedInfo.Friendliness = await _context.Friendliness.FirstOrDefaultAsync(m => m.ID == id);
            breedInfo.Grooming = await _context.Grooming.FirstOrDefaultAsync(m => m.ID == id);
            breedInfo.Health = await _context.Health.FirstOrDefaultAsync(m => m.ID == id);
            breedInfo.Training = await _context.Training.FirstOrDefaultAsync(m => m.ID == id);

            //var breedInfo = await _context.BreedInfo
            //    .FirstOrDefaultAsync(m => m.ID == id);
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
