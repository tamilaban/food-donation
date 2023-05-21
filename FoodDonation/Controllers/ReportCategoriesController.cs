using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDonation.Data;
using FoodDonation.Models;

namespace FoodDonation.Controllers
{
    public class ReportCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReportCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.reportCategories.ToListAsync());
        }

        // GET: ReportCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReportCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Category")] ReportCategory reportCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportCategory);
        }

        // GET: ReportCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportCategory = await _context.reportCategories.FindAsync(id);
            if (reportCategory == null)
            {
                return NotFound();
            }
            return View(reportCategory);
        }

        // POST: ReportCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Category")] ReportCategory reportCategory)
        {
            if (id != reportCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportCategoryExists(reportCategory.Id))
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
            return View(reportCategory);
        }

        // GET: ReportCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportCategory = await _context.reportCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reportCategory == null)
            {
                return NotFound();
            }

            return View(reportCategory);
        }

        // POST: ReportCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportCategory = await _context.reportCategories.FindAsync(id);
            _context.reportCategories.Remove(reportCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportCategoryExists(int id)
        {
            return _context.reportCategories.Any(e => e.Id == id);
        }
    }
}
