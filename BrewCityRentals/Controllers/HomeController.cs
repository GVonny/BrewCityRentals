using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrewCityRentals.Models;

namespace BrewCityRentals.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexModel model = new IndexModel()
            {
                Movie = new Movie
                {
                    Genres = new GenreList().GetGenres(),
                },
            };

            return View(model);
        }

        public ActionResult SearchResults(List<Movie> movies)
        {
            return View(movies);
        }

        [HttpPost]
        public ActionResult Search(Movie movie)
        {
            List<Movie> movies = new List<Movie>();

            return RedirectToAction("SearchResult", routeValues: new { movies });
        }
    }
}