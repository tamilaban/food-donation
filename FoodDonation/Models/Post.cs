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
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public DateTime PostCreatedDate { get; set; }
        public bool IsExpired { get; set; }
        public bool RequestStatus { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}

