using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class LeaderBoard
    {
        public int Id { get; set; }
        public string DonorId { get; set; }
        public int NumberofDonations { get; set; }
    }
}
