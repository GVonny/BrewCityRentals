using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class SearchModel
    {
        public List<Movie> Movies { get; set; }

        public List<Genre> Genres { get; set; }
    }
}