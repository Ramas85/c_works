using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public static class db
    {
        public static List<Booking> GetBookings()
        {
            Barber Paulius = new Barber() { Id =1, Name = "Paulius", Surname = "Kazkoks" };
            Barber Tomas = new Barber() { Id = 2, Name = "Tomas", Surname = "Sinickis" };
            Barber Barbora = new Barber() { Id = 3, Name = "Barbora", Surname = "Zirklyte" };

            List<Booking> bookings = new List<Booking>()
            {
                new Booking(){Id = 1, Barber = Paulius, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Id = 2, Barber = Tomas, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now},
                new Booking(){Id = 3, Barber = Barbora, BookingStatus = BookingStatus.available, AvailableTime = DateTime.Now.AddDays(-1)},
            };
            return bookings;
        }
    }
}
