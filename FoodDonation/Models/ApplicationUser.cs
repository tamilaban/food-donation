using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string OrganisationName { get; set; }
        public string About { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string WhatsAppNumber { get; set; }
    }
}
