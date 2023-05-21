using FoodDonation.Data;
using FoodDonation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Controllers
{
    [Authorize(Roles="Donor")]
    public class Donors : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _hostEnvironment;

        public Donors(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _hostEnvironment = hostEnvironment;
        }

        //Posts-actions-starts

        // GET: Posts
        public async Task<IActionResult> MyPosts()
        {
            var applicationDbContext = _context.Posts.Where(r => r.UserId == _userManager.GetUserId(HttpContext.User)).Include(p => p.User).OrderByDescending(r => r.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Posts/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> PostDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var a = _context.CharityNotifications.Where(r => r.PostId == id && r.CharityId == _userManager.GetUserId(HttpContext.User)).Select(r=> r.IsAccepted).FirstOrDefault();
            var b = _context.DonorNotifications.Where(r => r.PostId == id && r.CharityId == _userManager.GetUserId(HttpContext.User)).Select(r=> r.IsRequest).FirstOrDefault();
            if (a == true)
            {
                ViewBag.status = true;
            }else if (b ==true)
            {
                ViewBag.status = false;
            }
            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult CreatePost()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePost([Bind("Id,Title,Description,Quantity,Address,Date,Image,PostCreatedDateIsExpired,RequestStatus,UserId,ImageFile")] Post post )
        {
            if (ModelState.IsValid)
            {
                post.PostCreatedDate = DateTime.Now;
                post.IsExpired = false;
                post.RequestStatus = false;
                post.UserId = _userManager.GetUserId(HttpContext.User);
                //image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(post.ImageFile.FileName);
                string extension = Path.GetExtension(post.ImageFile.FileName);
                post.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/Image/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await post.ImageFile.CopyToAsync(fileStream);
                }
                //image

                _context.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyPosts));
            }
            return View(post);
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }
            //ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", post.UserId);
            return View(post);
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,UserId")] Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    post.UserId = _userManager.GetUserId(HttpContext.User);
                    _context.Update(post);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostExists(post.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(MyPosts));
            }
            //ViewData["UserId"] = new SelectList(_context.Set<ApplicationUser>(), "Id", "Id", post.UserId);
            return View(post);
        }

        // GET: Posts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _context.Posts
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "image", post.Image);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyPosts));
        }

        private bool PostExists(int id)
        {
            return _context.Posts.Any(e => e.Id == id);
        }
        //Posts-actions-End
        //Notifications-starts
        public async Task<IActionResult> Notifications()
        {
            return View(await _context.DonorNotifications.Where(r => r.DonorId == _userManager.GetUserId(HttpContext.User)).OrderByDescending(r=> r.Id).ToListAsync());
        }
        public async Task<IActionResult> NotificationDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var pid = await _context.DonorNotifications.Where(m => m.Id == id).Select(r=> r.PostId).FirstOrDefaultAsync();
            var ttile = await _context.Posts.Where(r => r.Id == pid).Select(r => r.Title).FirstOrDefaultAsync();
            ViewBag.newTitle = ttile;
            var notification = await _context.DonorNotifications.Where(m => m.Id == id).FirstOrDefaultAsync();
            

            if (notification == null)
            {
                return NotFound();
            }

            return View(notification);
        }

        public IActionResult RequestToDonate(int? id)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RequestToDonate(int id, CharityNotification cn)
        {
            string userId = _context.Posts.Where(r => r.Id == id).Select(r => r.UserId).FirstOrDefault();
            var a = _userManager.FindByIdAsync(userId).Result;
            var b = _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User)).Result;
            CharityNotification n = new CharityNotification();
            n.DonorId = _userManager.GetUserId(HttpContext.User);
            n.CharityId = userId;
            n.DonorName = b.FullName;
            n.CharityName = a.FullName;
            n.PostId = id;
            n.CreatedDate = DateTime.Now;
            n.ShortMsg = cn.ShortMsg;
            n.IsRequest = true;
            _context.Add(n);
            await _context.SaveChangesAsync();
            return RedirectToAction("feed","Home");
        }
        public async Task<IActionResult> Reject(int id)
        {
            string userId = _context.DonorNotifications.Where(r => r.Id == id).Select(r => r.CharityId).FirstOrDefault();
            int pid = _context.DonorNotifications.Where(r => r.Id == id).Select(r => r.PostId).FirstOrDefault();
            var a = _userManager.FindByIdAsync(userId).Result;
            var b = _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User)).Result;

            DonorNotification ab = _context.DonorNotifications.Where(r => r.Id == id).FirstOrDefault();
            ab.IsAccepted = false;
            _context.Update(ab);
            await _context.SaveChangesAsync();

            CharityNotification d = new CharityNotification();
            d.DonorId = _userManager.GetUserId(HttpContext.User);
            d.CharityId = userId;
            d.PostId = pid;
            d.IsAccepted = false;
            d.DonorName = b.FullName;
            d.CharityName = a.FullName;
            d.CreatedDate = DateTime.Now;
            _context.Add(d);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Notifications));
        }
        //Notifications-Ends
        //Donation-starts
        public async Task<IActionResult> Accept(int id)
        {
            string cId = _context.DonorNotifications.Where(r => r.Id == id).Select(r => r.CharityId).FirstOrDefault();
            int pid = _context.DonorNotifications.Where(r => r.Id == id).Select(r => r.PostId).FirstOrDefault();
            string ptitle = _context.Posts.Where(r => r.Id == pid).Select(r => r.Title).FirstOrDefault();
            string pDesc = _context.Posts.Where(r => r.Id == pid).Select(r => r.Description).FirstOrDefault();
            var ddate = await _context.Posts.Where(r => r.Id == pid).Select(r => r.PostCreatedDate).FirstOrDefaultAsync();
            bool isr = await _context.Posts.Where(r => r.Id == pid).Select(r => r.RequestStatus).FirstOrDefaultAsync();
            int quan = await _context.Posts.Where(r => r.Id == pid).Select(r => r.Quantity).FirstOrDefaultAsync();
            var pdate = await _context.Posts.Where(r => r.Id == pid).Select(r => r.Quantity).FirstOrDefaultAsync();

            var a = _userManager.FindByIdAsync(cId).Result;
            var b = _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User)).Result;

            DonorNotification ab = _context.DonorNotifications.Where(r => r.Id == id).FirstOrDefault();
            ab.IsAccepted = true;
            _context.Update(ab);
            await _context.SaveChangesAsync();
            Donation n = new Donation();
            n.DonorId = _userManager.GetUserId(HttpContext.User);
            n.CharityId = cId ;
            n.PostId = pid;
            n.pQuantity = quan;
            n.postTitle = ptitle;
            n.pDescription = pDesc;
            n.Isrequest = isr;
            n.DonorName = b.FullName;
            n.CharityName = a.FullName;
            n.Date = DateTime.Now;
            _context.Add(n);
            await _context.SaveChangesAsync();

            CharityNotification c = new CharityNotification();
            c.DonorId = _userManager.GetUserId(HttpContext.User);
            c.CharityId = cId;
            c.PostId = pid;
            c.IsAccepted = true;
            c.DonorName = b.FullName;
            c.CharityName = a.FullName;
            c.CreatedDate = DateTime.Now;
            _context.Add(c);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Notifications));
        }
       public async Task<IActionResult> Donations()
        {
            var applicationDbContext = _context.Donations.Where(r => r.DonorId == _userManager.GetUserId(HttpContext.User)).OrderByDescending(r => r.Id);
            return View(await applicationDbContext.ToListAsync());
        }
        //Donation-Ends
        [AllowAnonymous]
        public async Task<IActionResult> DonationDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var donation = await _context.Donations.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (donation == null)
            {
                return NotFound();
            }

            return View(donation);
        }
    }
}
