using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessFrog.Core.Domain;
using FitnessFrog.Core.Domain.Data;

namespace FitnessFrog.Core.UI.Controllers
{
    public class FoodsController : Controller
    {
        private readonly FitnessFrogDbContext _context;

        public FoodsController(FitnessFrogDbContext context)
        {
            _context = context;    
        }

        // GET: Foods
        public async Task<IActionResult> Index()
        {
            var fitnessFrogDbContext = _context.Foods.Include(f => f.Day).Include(f => f.User);
            return View(await fitnessFrogDbContext.ToListAsync());
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.SingleOrDefaultAsync(m => m.FoodId == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // GET: Foods/Create
        public IActionResult Create()
        {
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name");
            return View();
        }

        // POST: Foods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodId,Calories,Carbs,DayId,Fats,Name,Proteins,UserId")] Food food)
        {

            food.CreationDate = DateTime.Now;
            food.ModificationDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", food.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", food.UserId);
            return View(food);
        }

        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.SingleOrDefaultAsync(m => m.FoodId == id);
            if (food == null)
            {
                return NotFound();
            }
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", food.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", food.UserId);
            return View(food);
        }

        // POST: Foods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FoodId,Calories,Carbs,CreationDate,DayId,Fats,ModificationDate,Name,Proteins,UserId")] Food food)
        {
            if (id != food.FoodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodExists(food.FoodId))
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
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", food.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", food.UserId);
            return View(food);
        }

        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var food = await _context.Foods.SingleOrDefaultAsync(m => m.FoodId == id);
            if (food == null)
            {
                return NotFound();
            }

            return View(food);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var food = await _context.Foods.SingleOrDefaultAsync(m => m.FoodId == id);
            _context.Foods.Remove(food);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FoodExists(int id)
        {
            return _context.Foods.Any(e => e.FoodId == id);
        }
    }
}
