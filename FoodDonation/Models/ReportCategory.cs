using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class ReportCategory
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        public List<UserReport> reports { get; set; }
    }
}
