using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class Sponsors
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
       
        public string Logo { get; set; }
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
