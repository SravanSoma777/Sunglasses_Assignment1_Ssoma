using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sunglasses_Assignment1_Ssoma.Data;
using Sunglasses_Assignment1_Ssoma.Models;

namespace Sunglasses_Assignment1_Ssoma.Controllers
{
    public class SunglassesController : Controller
    {
        private readonly MvcSunglassesContext _context;

        public SunglassesController(MvcSunglassesContext context)
        {
            _context = context;
        }

        // GET: Sunglasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sunglasses.ToListAsync());
        }

        // GET: Sunglasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sunglasses = await _context.Sunglasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sunglasses == null)
            {
                return NotFound();
            }

            return View(sunglasses);
        }

        // GET: Sunglasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sunglasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,ReleaseDate,ShadeType,Price,review,country")] Sunglasses sunglasses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sunglasses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sunglasses);
        }

        // GET: Sunglasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sunglasses = await _context.Sunglasses.FindAsync(id);
            if (sunglasses == null)
            {
                return NotFound();
            }
            return View(sunglasses);
        }

        // POST: Sunglasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,name,ReleaseDate,ShadeType,Price,review,country")] Sunglasses sunglasses)
        {
            if (id != sunglasses.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sunglasses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SunglassesExists(sunglasses.Id))
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
            return View(sunglasses);
        }

        // GET: Sunglasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sunglasses = await _context.Sunglasses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sunglasses == null)
            {
                return NotFound();
            }

            return View(sunglasses);
        }

        // POST: Sunglasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sunglasses = await _context.Sunglasses.FindAsync(id);
            _context.Sunglasses.Remove(sunglasses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SunglassesExists(int id)
        {
            return _context.Sunglasses.Any(e => e.Id == id);
        }
    }
}
