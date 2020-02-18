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
                new Genre{ GenreID = new Guid("03e44fef-16d1-4fdb-a552-67ab6af2de18"), GenreName = "Action" },
                new Genre{ GenreID = new Guid("c0c689d0-6429-4881-980a-1dc114de41c1"), GenreName = "Horror" },
                new Genre{ GenreID = new Guid("1994ea36-1acf-4dcb-8b27-aa108b649f9d"), GenreName = "Comedy" },
            };

            return Genres;
        }
    }
}