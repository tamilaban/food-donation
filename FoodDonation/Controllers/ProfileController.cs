using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDonation.Data;
using FoodDonation.ViewModels;
using FoodDonation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace FoodDonation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProfileController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Profile
        [Authorize]
        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            ApplicationUser appUser = _userManager.FindByIdAsync(userId).Result;
            var proViewModel = new ProfileViewModel();
            proViewModel.Fullname = appUser.FullName;           
            proViewModel.OrganisationName = appUser.OrganisationName;
            proViewModel.Address = appUser.Address;
            proViewModel.ContactNumber = appUser.PhoneNumber;
            proViewModel.WhatsApp = appUser.WhatsAppNumber;
            proViewModel.About = appUser.About;
            ViewBag.userMail = appUser.Email;
            if (User.IsInRole("Donor"))
            {
                
                proViewModel.Donations = _context.Donations.Where(r => r.DonorId == userId).ToList();
                proViewModel.UserRole = "Donor";
                proViewModel.NumberofDonations = _context.Donations.Count(r => r.DonorId == userId);
                ViewBag.userstatus = true;
            }
            else if (User.IsInRole("Charity"))
            {

                proViewModel.NumberofDonations = _context.Donations.Count(r => r.CharityId == userId);
                proViewModel.Donations = _context.Donations.Where(r => r.CharityId == userId).ToList();
                proViewModel.UserRole = "Charity";
                ViewBag.userstatus = true;
            }
            else
            {
                ViewBag.userstatus = false;
            }

            return View(proViewModel);
        }
        public IActionResult UserProfile(int Id)
        {
            var userId = _context.Posts.Where(r => r.Id == Id).Select(r=>r.UserId).FirstOrDefault();
            var appUser = _userManager.FindByIdAsync(userId).Result;
            var proViewModel = new ProfileViewModel();
           proViewModel.Fullname = appUser.FullName;
            proViewModel.OrganisationName = appUser.OrganisationName;
            proViewModel.Address = appUser.Address;
            proViewModel.ContactNumber = appUser.PhoneNumber;
            proViewModel.WhatsApp = appUser.WhatsAppNumber;
            proViewModel.About = appUser.About;
            ViewBag.userMail = appUser.Email;
            var ad = _userManager.IsInRoleAsync(appUser, "Donor").Result;
            var ac = _userManager.IsInRoleAsync(appUser, "Charity").Result;
            if (ad == true )
            {

                proViewModel.Donations = _context.Donations.Where(r => r.DonorId == userId).ToList();
                proViewModel.UserRole = "Donor";
                proViewModel.NumberofDonations = _context.Donations.Count(r => r.DonorId == userId);
                ViewBag.userstatus = true;
            }
            else if (ac== true)
            {

                proViewModel.NumberofDonations = _context.Donations.Count(r => r.CharityId == userId);
                proViewModel.Donations = _context.Donations.Where(r => r.CharityId == userId).ToList();
                proViewModel.UserRole = "Charity";
                ViewBag.userstatus = true;
            }
            else
            {
                ViewBag.userstatus = false;
            }


            return View(proViewModel);
        }
    }
}
