using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class UserReport
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime reportDate { get; set; }
        [Required]
        public int catId { get; set; }
        public ReportCategory Categories { get; set; }
    }
}
