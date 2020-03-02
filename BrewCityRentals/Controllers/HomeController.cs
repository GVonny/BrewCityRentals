using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrewCityRentals.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

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
            if(!string.IsNullOrWhiteSpace(Movie.Title) || Movie.GenreID != Guid.Empty || Movie.SearchStartDate != null || Movie.SearchEndDate != null)
            {
                SearchModel model = new SearchModel();
                
                MovieList movieList = new MovieList();
                List<Movie> Movies = movieList.SearchMovies(Movie);
                model.Movies = Movies;

                GenreList genreList = new GenreList();
                model.Genres = genreList.GetGenres();

                return View(model);
            }
            return View(new SearchModel() { Movies = new List<Movie>() } );
            
        }
    }
}