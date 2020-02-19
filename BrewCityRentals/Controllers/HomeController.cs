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
                Genres = new GenreList().GetGenres(),
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Search(Movie Movie)
        {
            SearchModel model = new SearchModel();

            MovieList movieList = new MovieList();
            List<Movie> Movies = movieList.SearchMovies(Movie);
            model.Movies = Movies;

            GenreList genreList = new GenreList();
            model.Genres = genreList.GetGenres();
            
            return View(model);
        }
    }
}