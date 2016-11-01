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
    public class ExercisesController : Controller
    {
        private readonly FitnessFrogDbContext _context;

        public ExercisesController(FitnessFrogDbContext context)
        {
            _context = context;    
        }

        // GET: Exercises
        public async Task<IActionResult> Index()
        {
            var fitnessFrogDbContext = _context.Exercises.Include(e => e.Day).Include(e => e.User);
            return View(await fitnessFrogDbContext.ToListAsync());
        }

        // GET: Exercises/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.SingleOrDefaultAsync(m => m.ExerciseId == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // GET: Exercises/Create
        public IActionResult Create()
        {
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name");
            ViewData["ExerciseType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.ExerciseTypes)));
            ViewData["UnitType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.UnitTypes)));
            return View();
        }

        // POST: Exercises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExerciseId,DayId,ExerciseType,Reps,Sets,UnitType,UserId,Weight")] Exercise exercise)
        {
            exercise.CreationDate = DateTime.Now;
            exercise.ModificationDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(exercise);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", exercise.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", exercise.UserId);
            ViewData["ExerciseType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.ExerciseTypes)), exercise.ExerciseType);
            ViewData["UnitType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.UnitTypes)), exercise.UnitType);
            return View(exercise);
        }

        // GET: Exercises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.SingleOrDefaultAsync(m => m.ExerciseId == id);
            if (exercise == null)
            {
                return NotFound();
            }
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", exercise.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", exercise.UserId);
            ViewData["ExerciseType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.ExerciseTypes)), exercise.ExerciseType);
            ViewData["UnitType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.UnitTypes)), exercise.UnitType);
            return View(exercise);
        }

        // POST: Exercises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExerciseId,CreationDate,DayId,ExerciseType,ModificationDate,Reps,Sets,UnitType,UserId,Weight")] Exercise exercise)
        {
            if (id != exercise.ExerciseId)
            {
                return NotFound();
            }

            exercise.ModificationDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exercise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExerciseExists(exercise.ExerciseId))
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
            ViewData["DayId"] = new SelectList(_context.Days, "DayId", "DayId", exercise.DayId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Name", exercise.UserId);
            ViewData["ExerciseType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.ExerciseTypes)), exercise.ExerciseType);
            ViewData["UnitType"] = new SelectList(EntityHelper.GetConstants(typeof(EntityHelper.UnitTypes)), exercise.UnitType);
            return View(exercise);
        }

        // GET: Exercises/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.SingleOrDefaultAsync(m => m.ExerciseId == id);
            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // POST: Exercises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exercise = await _context.Exercises.SingleOrDefaultAsync(m => m.ExerciseId == id);
            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ExerciseExists(int id)
        {
            return _context.Exercises.Any(e => e.ExerciseId == id);
        }
    }
}
