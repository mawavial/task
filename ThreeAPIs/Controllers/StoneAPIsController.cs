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
    public class StoneAPIsController : Controller
    {
        private readonly ThreeAPIsContext _context;

        public StoneAPIsController(ThreeAPIsContext context)
        {
            _context = context;
        }

        // GET: StoneAPIs
        public async Task<IActionResult> Index()
        {
            return View(await _context.StoneAPI.ToListAsync());
        }

        // GET: StoneAPIs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneAPI = await _context.StoneAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (stoneAPI == null)
            {
                return NotFound();
            }

            return View(stoneAPI);
        }

        // GET: StoneAPIs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoneAPIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MerchantKey,CreditCardTransactionCollectionAmountCents,CreditCardTransactionCollectionCreditCardCreditCardBrand,CreditCardTransactionCollectionCreditCardCreditCardNumber,CreditCardTransactionCollectionCreditCardExpMonth,CreditCardTransactionCollectionCreditCardExpYear,CreditCardTransactionCollectionCreditCardSecurityCode,CreditCardTransactionCollectionCreditCardHolderName,CreditCardTransactionCollectionCreditCardInstallmentCount,OrderOrderReference")] StoneAPI stoneAPI)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stoneAPI);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stoneAPI);
        }

        // GET: StoneAPIs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneAPI = await _context.StoneAPI.SingleOrDefaultAsync(m => m.ID == id);
            if (stoneAPI == null)
            {
                return NotFound();
            }
            return View(stoneAPI);
        }

        // POST: StoneAPIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MerchantKey,CreditCardTransactionCollectionAmountCents,CreditCardTransactionCollectionCreditCardCreditCardBrand,CreditCardTransactionCollectionCreditCardCreditCardNumber,CreditCardTransactionCollectionCreditCardExpMonth,CreditCardTransactionCollectionCreditCardExpYear,CreditCardTransactionCollectionCreditCardSecurityCode,CreditCardTransactionCollectionCreditCardHolderName,CreditCardTransactionCollectionCreditCardInstallmentCount,OrderOrderReference")] StoneAPI stoneAPI)
        {
            if (id != stoneAPI.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stoneAPI);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoneAPIExists(stoneAPI.ID))
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
            return View(stoneAPI);
        }

        // GET: StoneAPIs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stoneAPI = await _context.StoneAPI
                .SingleOrDefaultAsync(m => m.ID == id);
            if (stoneAPI == null)
            {
                return NotFound();
            }

            return View(stoneAPI);
        }

        // POST: StoneAPIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stoneAPI = await _context.StoneAPI.SingleOrDefaultAsync(m => m.ID == id);
            _context.StoneAPI.Remove(stoneAPI);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StoneAPIExists(int id)
        {
            return _context.StoneAPI.Any(e => e.ID == id);
        }
    }
}
