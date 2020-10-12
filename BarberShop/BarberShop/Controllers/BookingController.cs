using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            Barber Paulius = new Barber() { Name = "Paulius", Surname = "Kazkoks" };
            Barber Tomas = new Barber() { Name = "Tomas", Surname = "Sinickis" };
            Barber Barbora = new Barber() { Name = "Barbora", Surname = "Zirklyte" };

            List<Booking> bookings = new List<Booking>()
            {
                new Booking(){Barber = Paulius, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Tomas, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Barber = Barbora, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now.AddDays(-1)},
            };
            return View(bookings);
        }
    }
}
