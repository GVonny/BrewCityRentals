using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrewCityRentals.Models;

namespace BrewCityRentals.Controllers
{
    public class InventoryController : Controller
    {
        public ActionResult MovieList()
        {
            return View();
        }

        public ActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMovie(Movie Movie)
        {
            return View("MovieList");
        }

        public ActionResult EditMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditMovie(Movie Movie)
        {
            return View("MovieList");
        }

        public ActionResult RemoveMovie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RemoveMovie(Movie Movie)
        {
            return View("MovieList");
        }
    }
}