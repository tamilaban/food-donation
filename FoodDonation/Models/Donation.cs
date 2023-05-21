using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string postTitle { get; set; }
        public string pDescription { get; set; }
        public int pQuantity { get; set; }
        public bool Isrequest { get; set; }
        public string DonorName { get; set; }
        public string CharityName { get; set; }
        public string DonorId { get; set; }
        public string CharityId { get; set; }
        public DateTime Date { get; set; }
    }
}

