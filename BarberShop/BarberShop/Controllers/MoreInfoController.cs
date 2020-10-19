using BarberShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class MoreInfoController : Controller
    {
        //Get: moreinfo
        public IActionResult Moreinfo()
        {
            var MoreBarberInfoList = new List<Barber> { 

                 new Barber() { Name = "Barbora", Surname = "Zirklyte", PhoneNumber = "+370 6565556", WorkingHours = "From 8:00 Am to 15:00 PM" }
            };
            /*
            List<Booking> bookings = new List<Booking>()
            {
                
                new Booking(){Barber = Barbora, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now, },
            };
            */
            return View(MoreBarberInfoList);
        }
    }
}
