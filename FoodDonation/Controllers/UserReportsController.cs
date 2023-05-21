using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDonation.Data;
using FoodDonation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FoodDonation.Controllers
{
    public class UserReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public UserReportsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: UserReports
        public async Task<IActionResult> Index()
        {
            ViewBag.Category =await _context.reportCategories.ToListAsync();
            return View(await _context.userReports.OrderByDescending(r=> r.Id).ToListAsync());
        }

        // GET: UserReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var userReport = await _context.userReports
                .FirstOrDefaultAsync(m => m.Id == id);
            ViewBag.Category = await _context.reportCategories.Where(r => r.Id == userReport.catId).Select(r=> r.Category).FirstOrDefaultAsync();
            
            if (userReport == null)
            {
                return NotFound();
            }

            return View(userReport);
        }

        // GET: UserReports/Create
        [Authorize(Roles = "Charity, Donor")]
        public IActionResult Create()
        {
            ViewData["cate"] = new SelectList(_context.reportCategories, "Id", "Category");
            return View();
        }

        [Authorize(Roles = "Charity, Donor")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,Description,catId")] UserReport userReport)
        {
            if (ModelState.IsValid)
            {
                var uName = _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User)).Result;
                userReport.UserName = uName.FullName;
                //userReport.catId = userReport.catId;
                userReport.reportDate = DateTime.Now;
                _context.Add(userReport);
                await _context.SaveChangesAsync();
                ViewBag.success = true;
                //return RedirectToAction(nameof(Index));
            }
            return View(userReport);
        }

        private bool UserReportExists(int id)
        {
            return _context.userReports.Any(e => e.Id == id);
        }
    }
}
