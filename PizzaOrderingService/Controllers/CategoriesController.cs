using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaOrderingService.Models;
using PizzaOrderingService.Repositories;
using Microsoft.AspNetCore.Authorization;
using PizzaOrderingService.Data;

namespace PizzaOrderingService.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICategoryRepository _categoryRepo;

        public CategoriesController(AppDbContext context, ICategoryRepository categoryRepo)
        {
            _context = context;
            _categoryRepo = categoryRepo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryRepo.GetAllAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoryRepo.GetByIdAsync(id);

            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Categories categories)
        {
            if (ModelState.IsValid)
            {
                _categoryRepo.Add(categories);
                await _categoryRepo.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(categories);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoryRepo.GetByIdAsync(id);

            if (categories == null)
            {
                return NotFound();
            }
            return View(categories);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Categories categories)
        {
            if (id != categories.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _categoryRepo.Update(categories);
                    await _categoryRepo.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriesExists(categories.Id))
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
            return View(categories);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categories = await _categoryRepo.GetByIdAsync(id);

            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categories = await _categoryRepo.GetByIdAsync(id);
            _categoryRepo.Remove(categories);
            await _categoryRepo.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private bool CategoriesExists(int id)
        {
            return _categoryRepo.Exists(id);
        }
    }
}
