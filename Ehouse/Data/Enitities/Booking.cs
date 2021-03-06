﻿using Ehouse.Data.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehouse.Data.Enitities
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingTime { get; set; }
        public string Postcode { get; set; }
        public Photographer photographer { get; set; }
        public ICollection<Category> Category { get; set; }
        public ApplicationUser User { get; set; } // user that owns the Booking + identity/authorised user to this booking
    }
}
