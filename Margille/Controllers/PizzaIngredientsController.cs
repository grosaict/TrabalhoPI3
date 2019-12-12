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
    public class PizzaIngredientsController : Controller
    {
        private readonly MargilleContext _context;

        public PizzaIngredientsController(MargilleContext context)
        {
            _context = context;
        }

        // GET: PizzaIngredients
        public async Task<IActionResult> Index()
        {
            //var margilleContext = _context.PizzaIngredient.Include(p => p.Ingredient).Include(p => p.Pizza);
            //return View(await margilleContext.ToListAsync());
            return View(FindAll());
        }

        public List<PizzaIngredient> FindAll()
        {
            var margilleContext = _context.PizzaIngredient.Include(p => p.Ingredient).Include(p => p.Pizza);
            return margilleContext.ToList();
        }

        // Retorna ingredientes de uma pizza
        public List<PizzaIngredient> FindPizzaIngredients(int id)
        {
            var pizzaIngredient = _context.PizzaIngredient
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .Where(m => m.PizzaId == id);

            return pizzaIngredient.ToList();
        }


        // GET: PizzaIngredients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredient
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            return View(pizzaIngredient);
        }

        // GET: PizzaIngredients/Create
        public IActionResult Create()
        {
            ViewData["Ingredient"] = new SelectList(_context.Ingredient, "IngredientId", "IngredientName");
            ViewData["Pizza"] = new SelectList(_context.Pizza, "ProductId", "PizzaDescription");
            return View();
        }

        // POST: PizzaIngredients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,IngredientId")] PizzaIngredient pizzaIngredient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizzaIngredient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "IngredientId", "IngredientId", pizzaIngredient.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizza, "ProductId", "PizzaDescription", pizzaIngredient.PizzaId);

            return View(pizzaIngredient);
        }

        // GET: PizzaIngredients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredient.FindAsync(id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "IngredientId", "IngredientId", pizzaIngredient.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizza, "ProductId", "Discriminator", pizzaIngredient.PizzaId);
            return View(pizzaIngredient);
        }

        // POST: PizzaIngredients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,IngredientId")] PizzaIngredient pizzaIngredient)
        {
            if (id != pizzaIngredient.PizzaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzaIngredient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaIngredientExists(pizzaIngredient.PizzaId))
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
            ViewData["IngredientId"] = new SelectList(_context.Ingredient, "IngredientId", "IngredientId", pizzaIngredient.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizza, "ProductId", "Discriminator", pizzaIngredient.PizzaId);
            return View(pizzaIngredient);
        }

        // GET: PizzaIngredients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredient = await _context.PizzaIngredient
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizzaIngredient == null)
            {
                return NotFound();
            }

            return View(pizzaIngredient);
        }

        // POST: PizzaIngredients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzaIngredient = await _context.PizzaIngredient.FindAsync(id);
            _context.PizzaIngredient.Remove(pizzaIngredient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaIngredientExists(int id)
        {
            return _context.PizzaIngredient.Any(e => e.PizzaId == id);
        }
    }
}
