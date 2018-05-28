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
    public class CieloAPIsController : Controller
    {
        private readonly ThreeAPIsContext _context;

        public CieloAPIsController(ThreeAPIsContext context)
        {
            _context = context;
        }

        // GET: CieloAPIs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CieloAPI.ToListAsync());
        }

        // GET: CieloAPIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cieloAPI = await _context.CieloAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cieloAPI == null)
            {
                return NotFound();
            }

            return View(cieloAPI);
        }

        // GET: CieloAPIs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CieloAPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,ReleaseDate,Genre,Price,MerchantKey,CreditCardTransactionCollectionAmountCents,CreditCardTransactionCollectionCreditCardCreditCardBrand,CreditCardTransactionCollectionCreditCardCreditCardNumber,CreditCardTransactionCollectionCreditCardExpMonth,CreditCardTransactionCollectionCreditCardExpYear,CreditCardTransactionCollectionCreditCardSecurityCode,CreditCardTransactionCollectionCreditCardHolderName,CreditCardTransactionCollectionCreditCardInstallmentCount,OrderOrderReference")] CieloAPI cieloAPI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cieloAPI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cieloAPI);
        }

        // GET: CieloAPIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cieloAPI = await _context.CieloAPI.SingleOrDefaultAsync(m => m.ID == id);
            if (cieloAPI == null)
            {
                return NotFound();
            }
            return View(cieloAPI);
        }

        // POST: CieloAPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,Genre,Price,MerchantKey,CreditCardTransactionCollectionAmountCents,CreditCardTransactionCollectionCreditCardCreditCardBrand,CreditCardTransactionCollectionCreditCardCreditCardNumber,CreditCardTransactionCollectionCreditCardExpMonth,CreditCardTransactionCollectionCreditCardExpYear,CreditCardTransactionCollectionCreditCardSecurityCode,CreditCardTransactionCollectionCreditCardHolderName,CreditCardTransactionCollectionCreditCardInstallmentCount,OrderOrderReference")] CieloAPI cieloAPI)
        {
            if (id != cieloAPI.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cieloAPI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CieloAPIExists(cieloAPI.ID))
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
            return View(cieloAPI);
        }

        // GET: CieloAPIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cieloAPI = await _context.CieloAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cieloAPI == null)
            {
                return NotFound();
            }

            return View(cieloAPI);
        }

        // POST: CieloAPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cieloAPI = await _context.CieloAPI.SingleOrDefaultAsync(m => m.ID == id);
            _context.CieloAPI.Remove(cieloAPI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CieloAPIExists(int id)
        {
            return _context.CieloAPI.Any(e => e.ID == id);
        }
    }
}
