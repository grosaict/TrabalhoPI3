using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Margille.Models;

namespace Margille.Controllers
{
    public class ProductOrdersController : Controller
    {
        private readonly MargilleContext _context;

        public ProductOrdersController(MargilleContext context)
        {
            _context = context;
        }

        // GET: ProductOrders
        public async Task<IActionResult> Index()
        {
            var margilleContext = _context.ProductOrder.Include(p => p.Order).Include(p => p.Product);
            return View(await margilleContext.ToListAsync());
        }

        // GET: ProductOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrder
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }

        // GET: ProductOrders/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Discriminator");
            return View();
        }

        // POST: ProductOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,OrderId,ProductQtd,OrderProductPrice")] ProductOrder productOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", productOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Discriminator", productOrder.ProductId);
            return View(productOrder);
        }

        // GET: ProductOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrder.FindAsync(id);
            if (productOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", productOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Discriminator", productOrder.ProductId);
            return View(productOrder);
        }

        // POST: ProductOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,OrderId,ProductQtd,OrderProductPrice")] ProductOrder productOrder)
        {
            if (id != productOrder.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductOrderExists(productOrder.ProductId))
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
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId", productOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Discriminator", productOrder.ProductId);
            return View(productOrder);
        }

        // GET: ProductOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrder
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }

        // POST: ProductOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productOrder = await _context.ProductOrder.FindAsync(id);
            _context.ProductOrder.Remove(productOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductOrderExists(int id)
        {
            return _context.ProductOrder.Any(e => e.ProductId == id);
        }
    }
}
