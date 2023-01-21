using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie
            {
                Id = 1,
                Name = "Shrek!"
            };
            ViewData["RandomMovie"] = movie;
            ViewBag.Movie = movie;
            return View();
        }

        //Custom Route used by 
        //routes.MapMvcAttributeRoutes();
        /*
         * month with 2 digits and among 1-12
         * */
        [Route("movies/released/{year:regex(\\d{4}):range(2012,2015)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}