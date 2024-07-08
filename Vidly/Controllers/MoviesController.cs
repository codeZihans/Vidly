using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {Name ="Customer 1"},
                new Customer { Name ="Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers,
            };

            return View(viewModel);
        }

        //Custom Route used by 
        //routes.MapMvcAttributeRoutes();
        /*
         * month with 2 digits and among 1-12
         * */
       // [Route("movies/released/{year:regex(\\d{4}):range(2012,2015)}/{month:regex(\\d{2}):range(1,12)}")]
      //  public ActionResult ByReleaseYear(int year, int month)
      //  {
       //     return Content(year + "/" + month);
       // }
    }
}