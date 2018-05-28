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
    public class CieloesController : Controller
    {
        private readonly DotNetCoreSqlDbContext _context;

        public CieloesController(DotNetCoreSqlDbContext context)
        {
            _context = context;
        }

        // GET: Cieloes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cielo.ToListAsync());
        }

        // GET: Cieloes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cielo = await _context.Cielo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cielo == null)
            {
                return NotFound();
            }

            return View(cielo);
        }

        // GET: Cieloes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cieloes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,ReleaseDate,Genre,Price")] Cielo cielo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cielo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cielo);
        }

        // GET: Cieloes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cielo = await _context.Cielo.SingleOrDefaultAsync(m => m.ID == id);
            if (cielo == null)
            {
                return NotFound();
            }
            return View(cielo);
        }

        // POST: Cieloes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,Genre,Price")] Cielo cielo)
        {
            if (id != cielo.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cielo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CieloExists(cielo.ID))
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
            return View(cielo);
        }

        // GET: Cieloes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cielo = await _context.Cielo
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cielo == null)
            {
                return NotFound();
            }

            return View(cielo);
        }

        // POST: Cieloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cielo = await _context.Cielo.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cielo.Remove(cielo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CieloExists(int id)
        {
            return _context.Cielo.Any(e => e.ID == id);
        }
    }
}
