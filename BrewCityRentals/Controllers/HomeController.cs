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
            return View();
        }

        public ActionResult SearchResults(Movie movie)
        {
            return View(movie);
        }

        [HttpPost]
        public ActionResult Search(Movie movie)
        {


            return RedirectToAction("SearchResult", routeValues: new { movie });
        }
    }
}