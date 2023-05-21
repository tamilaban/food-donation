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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace FoodDonation.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hostEnvironment;
        public AdminController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Admin
        public async Task<IActionResult> ListofSponsors()
        {
            return View(await _context.Sponsors.ToListAsync());
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> SponsorDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsors = await _context.Sponsors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sponsors == null)
            {
                return NotFound();
            }

            return View(sponsors);
        }

        // GET: Admin/Create
        public IActionResult CreateSponsor()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSponsor([Bind("Id,Amount,Name,startDate,ExpireDate,Logo,ImageFile")] Sponsors sponsors)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(sponsors.ImageFile.FileName);
                string extension = Path.GetExtension(sponsors.ImageFile.FileName);
                sponsors.Logo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await sponsors.ImageFile.CopyToAsync(fileStream);
                }
                _context.Add(sponsors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListofSponsors));
            }
            return View(sponsors);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> EditSponsor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsors = await _context.Sponsors.FindAsync(id);
            if (sponsors == null)
            {
                return NotFound();
            }
            return View(sponsors);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSponsor(int id, [Bind("Id,Name,startDate,ExpireDate,Logo")] Sponsors sponsors)
        {
            if (id != sponsors.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sponsors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SponsorsExists(sponsors.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ListofSponsors));
            }
            return View(sponsors);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> DeleteSponsor(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sponsors = await _context.Sponsors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sponsors == null)
            {
                return NotFound();
            }

            return View(sponsors);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("DeleteSponsor")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sponsors = await _context.Sponsors.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", sponsors.Logo);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.Sponsors.Remove(sponsors);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ListofSponsors));
        }
        public async Task<IActionResult> Notifications()
        {
   
            return View(await _context.userReports.OrderByDescending(r => r.Id).ToListAsync());
        }
        private bool SponsorsExists(int id)
        {
            return _context.Sponsors.Any(e => e.Id == id);
        }
    }
}
