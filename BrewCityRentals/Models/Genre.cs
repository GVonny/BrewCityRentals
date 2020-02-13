using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Genre
    {
        public Guid GenreID { get; set; }

        public string GenreName { get; set; }

        
    }

    public class GenreList
    {
        public GenreList() { }

        public List<Genre> GetGenres()
        {
            List<Genre> Genres = new List<Genre>()
            {
                new Genre{ GenreName = "Action" },
                new Genre{ GenreName = "Horror" },
                new Genre{ GenreName = "Comedy" },
            };

            return Genres;
        }
    }
}