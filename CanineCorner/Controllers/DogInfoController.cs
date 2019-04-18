using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CanineCorner.Models;
using Microsoft.AspNetCore.Identity;

namespace CanineCorner.Controllers
{
    public class DogInfoController : Controller
    {
        private readonly CanineCornerContext _context;
        private readonly UserManager<CanineCorner.Areas.Identity.Data.CanineCornerUser> _userManager;
        private string _currentUser { get { return _userManager.GetUserId(User); } }

        public DogInfoController(CanineCornerContext context, UserManager<CanineCorner.Areas.Identity.Data.CanineCornerUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: DogInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.DogInfo.Where(p => p.User == _currentUser).ToListAsync());
            //return View(await _context.DogInfo.ToListAsync());
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
        public async Task<IActionResult> Create()
        {
            if (_currentUser == null)
            {
                return View("Index", await _context.DogInfo.Where(p => p.User == _currentUser).ToListAsync());
            }
            else
            {
                return View();
            }
        }

        // POST: DogInfo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,User,DogName,Breed,Weight,Height,DoB,TodayDate")] DogInfo dogInfo)
        {
            dogInfo.User = _currentUser;
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
