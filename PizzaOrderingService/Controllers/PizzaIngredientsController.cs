using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaOrderingService.Models;
using Microsoft.AspNetCore.Authorization;
using PizzaOrderingService.Data;

namespace PizzaOrderingService.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PizzaIngredientsController : Controller
    {
        private readonly AppDbContext _context;

        public PizzaIngredientsController(AppDbContext context)
        {
            _context = context;    
        }

        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.PizzaIngredients.Include(p => p.Ingredient).Include(p => p.Pizza);
            return View(await appDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredients = await _context.PizzaIngredients
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (pizzaIngredients == null)
            {
                return NotFound();
            }

            return View(pizzaIngredients);
        }

        public IActionResult Create()
        {
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name");
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PizzaId,IngredientId")] PizzaIngredients pizzaIngredients)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizzaIngredients);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name", pizzaIngredients.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Name", pizzaIngredients.PizzaId);
            return View(pizzaIngredients);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredients = await _context.PizzaIngredients.SingleOrDefaultAsync(m => m.Id == id);
            if (pizzaIngredients == null)
            {
                return NotFound();
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name", pizzaIngredients.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Name", pizzaIngredients.PizzaId);
            return View(pizzaIngredients);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PizzaId,IngredientId")] PizzaIngredients pizzaIngredients)
        {
            if (id != pizzaIngredients.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzaIngredients);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaIngredientsExists(pizzaIngredients.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["IngredientId"] = new SelectList(_context.Ingredients, "Id", "Name", pizzaIngredients.IngredientId);
            ViewData["PizzaId"] = new SelectList(_context.Pizzas, "Id", "Name", pizzaIngredients.PizzaId);
            return View(pizzaIngredients);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaIngredients = await _context.PizzaIngredients
                .Include(p => p.Ingredient)
                .Include(p => p.Pizza)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (pizzaIngredients == null)
            {
                return NotFound();
            }

            return View(pizzaIngredients);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzaIngredients = await _context.PizzaIngredients.SingleOrDefaultAsync(m => m.Id == id);
            _context.PizzaIngredients.Remove(pizzaIngredients);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PizzaIngredientsExists(int id)
        {
            return _context.PizzaIngredients.Any(e => e.Id == id);
        }
    }
}
