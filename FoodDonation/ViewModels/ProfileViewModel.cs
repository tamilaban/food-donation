using FoodDonation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.ViewModels
{
    public class ProfileViewModel
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string UserRole { get; set; }
        public string OrganisationName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string WhatsApp { get; set; }
        public string About { get; set; }
        public int NumberofDonations { get; set; }
        public List<Donation> Donations { get; set; }
    }
}
