using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Barber : Person
    {
        public Barber()
        {
            int Id = 1;
        }
        public string PhoneNumber { get; set; }
        public DateTime AvailableTime { get; set; }
        public string WorkingHours { get; set; }

    }
}
