using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Movie
    {
        public Guid MovieID { get; set; }

        [DisplayName("Genre")]
        public Guid GenreID { get; set; }

        public int MovieCode { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public int QuantityAvailabe { get; set; }

        public DateTime ReleaseDate { get; set; }

        [NotMapped]
        public List<Genre> Genres { get; set; }
    }
}