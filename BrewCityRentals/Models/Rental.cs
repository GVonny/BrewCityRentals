using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Rental
    {
        public Guid RentalID { get; set; }

        public Guid MovieID { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}