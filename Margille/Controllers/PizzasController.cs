﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Margille.Models;

namespace Margille.Controllers
{
    public class PizzasController : Controller
    {
        private readonly MargilleContext _context;

        public PizzasController(MargilleContext context)
        {
            _context = context;
        }

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Pizza.ToListAsync());
            return View(FindAll());
        }

        public List<Pizza> FindAll()
        {
            var pizzas = new List<Pizza>();
            //pizzas = _context.Pizza.ToList();

            // Incluindo os ingredientes no objeto
            pizzas = _context.Pizza
                    .Include(pi => pi.PizzaIngredients)
                        .ThenInclude(pi => pi.Ingredient)
                    .AsNoTracking()
                    .ToList();

            /* viewModel.Instructors = await _context.Instructors
              .Include(i => i.OfficeAssignment)
              .Include(i => i.CourseAssignments)
                .ThenInclude(i => i.Course)
                    .ThenInclude(i => i.Enrollments)
                        .ThenInclude(i => i.Student)
              .Include(i => i.CourseAssignments)
                .ThenInclude(i => i.Course)
                    .ThenInclude(i => i.Department)
              .AsNoTracking()
              .OrderBy(i => i.LastName)
              .ToListAsync();
            */

            // Incluindo os ingredientes no objeto
            /*foreach (Pizza pizza in pizzas)
            {
                pizza.PizzaIngredients = _context.PizzaIngredient
                    .Include(i => i.Ingredient)
                    .Include(p => p.Pizza)
                    .Where(p => p.PizzaId == pizza.ProductId)
                    .ToList();
            }*/

            return pizzas;
        }

        public Pizza FindPizza(int? id)
        {
            var pizza = _context.Pizza
                .Include(pi => pi.PizzaIngredients)
                    .ThenInclude(pi => pi.Ingredient)
                .AsNoTracking()
                .FirstOrDefault(m => m.ProductId == id);

            return pizza;
        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var pizza = await _context.Pizza
                .FirstOrDefaultAsync(m => m.ProductId == id);*/
            var pizza = FindPizza(id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // GET: Pizzas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pizzas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaDescription,ProductId,ProductName,ProductPrice")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pizza);
        }

        // GET: Pizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var pizza = await _context.Pizza.FindAsync(id);

            var pizza = FindPizza(id);

            if (pizza == null)
            {
                return NotFound();
            }
            return View(pizza);
        }

        // POST: Pizzas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaDescription,ProductId,ProductName,ProductPrice")] Pizza pizza)
        {
            if (id != pizza.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExists(pizza.ProductId))
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
            return View(pizza);
        }

        // GET: Pizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            /*var pizza = await _context.Pizza
                .FirstOrDefaultAsync(m => m.ProductId == id);*/

            var pizza = FindPizza(id);

            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // POST: Pizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizza = await _context.Pizza.FindAsync(id);
            _context.Pizza.Remove(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizza.Any(e => e.ProductId == id);
        }
    }
}
