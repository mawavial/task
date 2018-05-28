using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThreeAPIs.Models;

namespace ThreeAPIs.Controllers
{
    public class ClearSecuAPIsController : Controller
    {
        private readonly ThreeAPIsContext _context;

        public ClearSecuAPIsController(ThreeAPIsContext context)
        {
            _context = context;
        }

        // GET: ClearSecuAPIs
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClearSecuAPI.ToListAsync());
        }

        // GET: ClearSecuAPIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clearSecuAPI = await _context.ClearSecuAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (clearSecuAPI == null)
            {
                return NotFound();
            }

            return View(clearSecuAPI);
        }

        // GET: ClearSecuAPIs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClearSecuAPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ApiKey,LoginToken,AnalysisLocation")] ClearSecuAPI clearSecuAPI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clearSecuAPI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clearSecuAPI);
        }

        // GET: ClearSecuAPIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clearSecuAPI = await _context.ClearSecuAPI.SingleOrDefaultAsync(m => m.ID == id);
            if (clearSecuAPI == null)
            {
                return NotFound();
            }
            return View(clearSecuAPI);
        }

        // POST: ClearSecuAPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ApiKey,LoginToken,AnalysisLocation")] ClearSecuAPI clearSecuAPI)
        {
            if (id != clearSecuAPI.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clearSecuAPI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClearSecuAPIExists(clearSecuAPI.ID))
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
            return View(clearSecuAPI);
        }

        // GET: ClearSecuAPIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clearSecuAPI = await _context.ClearSecuAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (clearSecuAPI == null)
            {
                return NotFound();
            }

            return View(clearSecuAPI);
        }

        // POST: ClearSecuAPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clearSecuAPI = await _context.ClearSecuAPI.SingleOrDefaultAsync(m => m.ID == id);
            _context.ClearSecuAPI.Remove(clearSecuAPI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClearSecuAPIExists(int id)
        {
            return _context.ClearSecuAPI.Any(e => e.ID == id);
        }
    }
}
