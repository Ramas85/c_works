﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Client : Person
    {
        public Client()
        {
            Id = Guid.NewGuid();
        }
    }
}
