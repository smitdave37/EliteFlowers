



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EliteFlowers.Data;
using EliteFlowers.Models;
using Microsoft.AspNetCore.Authorization;

namespace EliteFlowers.Controllers
{

    public class FlowersController : Controller
    {
        private readonly EliteFlowersContext _context;
        public FlowersController(EliteFlowersContext context)
        {
            _context = context;
        }

        // GET: Flowers
        public async Task<IActionResult> Index(string flowerColor, string searchString)
        {
            if (_context.Flowers == null)
            {
                return Problem("Entity set 'EliteFlowersContext.Flowers'  is null.");
            }
            IQueryable<string> ColorQuery = from m in _context.Flowers
                                            orderby m.Color
                                            select m.Color;
            var flowers = from m in _context.Flowers
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                flowers = flowers.Where(s => s.FlowerType!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(flowerColor))
            {
                flowers = flowers.Where(x => x.Color == flowerColor);
            }
            var flowerColorVM = new FlowerColorViewModel
            {
                Colors = new SelectList(await ColorQuery.Distinct().ToListAsync()),
                Flowers = await flowers.ToListAsync()
            };
            
            return View(flowerColorVM);
        }

        // GET: Flowers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowers = await _context.Flowers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flowers == null)
            {
                return NotFound();
            }

            return View(flowers);
        }

        [Authorize(Roles = "Admin")]
        // GET: Flowers/Create
        public IActionResult Create()
        {
            return View();
        }
     
        // POST: Flowers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FlowerType,Quantity,Color,Price,Size")] Flowers flowers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flowers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(flowers);
        }
        [Authorize(Roles = "Admin")]
        // GET: Flowers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowers = await _context.Flowers.FindAsync(id);
            if (flowers == null)
            {
                return NotFound();
            }
            return View(flowers);
        }
        [Authorize(Roles = "Admin")]
        // POST: Flowers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlowerType,Quantity,Color,Price,Size")] Flowers flowers)
        {
            if (id != flowers.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flowers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlowersExists(flowers.Id))
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
            return View(flowers);
        }

        [Authorize(Roles = "Admin")]
        // GET: Flowers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flowers = await _context.Flowers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flowers == null)
            {
                return NotFound();
            }

            return View(flowers);
        }

        // POST: Flowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flowers = await _context.Flowers.FindAsync(id);
            if (flowers != null)
            {
                _context.Flowers.Remove(flowers);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlowersExists(int id)
        {
            return _context.Flowers.Any(e => e.Id == id);
        }
    }
}
