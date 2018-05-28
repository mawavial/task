using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotNetCoreSqlDb.Models;

namespace DotNetCoreSqlDb.Controllers
{
    public class ClearsController : Controller
    {
        private readonly DotNetCoreSqlDbContext _context;

        public ClearsController(DotNetCoreSqlDbContext context)
        {
            _context = context;
        }

        // GET: Clears
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clear.ToListAsync());
        }

        // GET: Clears/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clear = await _context.Clear
                .SingleOrDefaultAsync(m => m.ID == id);
            if (clear == null)
            {
                return NotFound();
            }

            return View(clear);
        }

        // GET: Clears/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,ReleaseDate,Genre,Price")] Clear clear)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clear);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clear);
        }

        // GET: Clears/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clear = await _context.Clear.SingleOrDefaultAsync(m => m.ID == id);
            if (clear == null)
            {
                return NotFound();
            }
            return View(clear);
        }

        // POST: Clears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,Genre,Price")] Clear clear)
        {
            if (id != clear.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clear);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClearExists(clear.ID))
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
            return View(clear);
        }

        // GET: Clears/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clear = await _context.Clear
                .SingleOrDefaultAsync(m => m.ID == id);
            if (clear == null)
            {
                return NotFound();
            }

            return View(clear);
        }

        // POST: Clears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clear = await _context.Clear.SingleOrDefaultAsync(m => m.ID == id);
            _context.Clear.Remove(clear);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClearExists(int id)
        {
            return _context.Clear.Any(e => e.ID == id);
        }
    }
}
