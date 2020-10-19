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
        private readonly BookingService service;

        public Booking Controller(BookingService service)
        {
            this.service = service;
        }


        public IActionResult Index(int? id)
        {
            var bookings = db.GetBookings();

            if (id != null )
            {
                return View("~/View/Booking/BookingDetails.cshtml", bookings.Where(b => b.Id == id).FirstOrDefault());
            }
                return View(bookings);
        }
        [HttpPost]
        public IActionResult Register(RegisterDetails model)
        {
            if (ModelState.IsValid) 
            {
                return View();
            }
            return View();//error view
        }
    }
}
