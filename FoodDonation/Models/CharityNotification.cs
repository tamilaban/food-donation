using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonation.Models
{
    public class CharityNotification
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string ShortMsg { get; set; }
        public bool? IsAccepted { get; set; }
        public bool IsRead { get; set; }
        public bool IsRequest { get; set; }
        public DateTime CreatedDate { get; set; }
        public string DonorName { get; set; }
        public string CharityName { get; set; }
        public string DonorId { get; set; }
        public string CharityId { get; set; }
    }
}
