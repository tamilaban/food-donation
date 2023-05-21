using FoodDonation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FoodDonation.ViewModels;

namespace FoodDonation.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<DonorNotification> DonorNotifications  { get; set; }
        public DbSet<CharityNotification> CharityNotifications  { get; set; }
        public DbSet<Donation> Donations { get; set; }
        //public DbSet<LeaderBoard> leaders { get; set; }
        public DbSet<Sponsors> Sponsors { get; set; }
        public DbSet<UserReport> userReports  { get; set; }
        public DbSet<ReportCategory> reportCategories { get; set; }
        //public DbSet<LeaderBoard> leaders { get; set; }
        //public DbSet<ProfileViewModel> ProfileViewModel { get; set; }
        //public DbSet<ContactUs> ContactUs { get; set; }

    }
}
