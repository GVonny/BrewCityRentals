using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Movie
    {
        public Guid MovieID { get; set; }

        public int MovieCode { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Rating { get; set; }

        public int QuantityAvailabe { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}