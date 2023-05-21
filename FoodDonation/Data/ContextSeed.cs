using FoodDonation.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FoodDonation.Data
{

    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            //var hasher = new PasswordHasher<ApplicationUser>();

            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));
             await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Charity.ToString()));
             await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Donor.ToString()));
            var defaultUser = new ApplicationUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                FullName="John Smith"
             };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Wow123!");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.Admin.ToString());
                }
            }
        }
    }

    internal class Enums
    {
        public enum Roles
        {
            Charity,
            Donor,
            Admin
        }
    }
}

