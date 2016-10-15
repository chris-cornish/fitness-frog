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
    public class DaysController : Controller
    {
        private readonly FitnessFrogDbContext _context;

        public DaysController(FitnessFrogDbContext context)
        {
            _context = context;    
        }

        // GET: Days
        public async Task<IActionResult> Index()
        {
            var fitnessFrogDbContext = _context.Days.Include(d => d.User);
            return View(await fitnessFrogDbContext.ToListAsync());
        }

        // GET: Days/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var day = await _context.Days.SingleOrDefaultAsync(m => m.DayId == id);
            if (day == null)
            {
                return NotFound();
            }

            return View(day);
        }

        // GET: Days/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailAddress");
            return View();
        }

        // POST: Days/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DayId,CreationDate,EntryDate,ModificationDate,UserId")] Day day)
        {
            if (ModelState.IsValid)
            {
                _context.Add(day);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailAddress", day.UserId);
            return View(day);
        }

        // GET: Days/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var day = await _context.Days.SingleOrDefaultAsync(m => m.DayId == id);
            if (day == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailAddress", day.UserId);
            return View(day);
        }

        // POST: Days/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DayId,CreationDate,EntryDate,ModificationDate,UserId")] Day day)
        {
            if (id != day.DayId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(day);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DayExists(day.DayId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "EmailAddress", day.UserId);
            return View(day);
        }

        // GET: Days/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var day = await _context.Days.SingleOrDefaultAsync(m => m.DayId == id);
            if (day == null)
            {
                return NotFound();
            }

            return View(day);
        }

        // POST: Days/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var day = await _context.Days.SingleOrDefaultAsync(m => m.DayId == id);
            _context.Days.Remove(day);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool DayExists(int id)
        {
            return _context.Days.Any(e => e.DayId == id);
        }
    }
}
