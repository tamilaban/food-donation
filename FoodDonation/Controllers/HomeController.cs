using FoodDonation.Data;
using FoodDonation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FoodDonation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        //SignInManager<ApplicationUser> SignInManager

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var sponsors = _context.Sponsors.ToList();
            return View(sponsors);
        }
        /* public async Task<IActionResult> Feed()
         {
             var post = new List<Post>();
             if (User.IsInRole("Donor"))
             {
                 post = await _context.posts.Where(r => r.IsExpired == false && r.RequestStatus == true).Include(x => x.User).ToListAsync();
             }
             else if (User.IsInRole("Charity"))
             {
                 post = await _context.posts.Where(r => r.IsExpired == false && r.RequestStatus == false).Include(x => x.User).ToListAsync();
             }
             else
             {
                 post = await _context.posts.Where(r => r.IsExpired == false).Include(x => x.User).ToListAsync();
             }
             return View(post);
         }*/
        public async Task<IActionResult> Feed()
        {
            var applicationDbContext = _context.Posts.Include(p => p.User).OrderByDescending(r=> r.Id);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Leaderboard()
        {
            var result = await _context.Donations
        .GroupBy(x => x.DonorName)
        .Select(g => new LeaderBoard()
        {
            DonorId = g.Key,
            NumberofDonations = g.Count(),
        }).OrderByDescending(r=> r.NumberofDonations)
        .ToListAsync();
            return View(result);
        }
        public IActionResult Contactus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contactus(ContactUs vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress("rabsah5@gmail.com");//Email which you are getting 
                                                                    //from contact us page 
                    msz.To.Add("rabsah5@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = "Email:" + vm.Email + "<br>Name:" + vm.Name + "<br> Message:" + vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("rabsah5@gmail.com", "rabsah175", "gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
