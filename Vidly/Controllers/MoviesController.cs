using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Fight Club"} ,
                new Movie {Name = "Inception"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movies = movies
            };
            return View(viewModel);

        }
        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customers = new List<Customer>
        //    {
        //        new Customer{Name = "Customer 1" },
        //        new Customer{Name = "Customer 2" },
        //    };
        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Customers = customers
        //    };
        //    return View(viewModel);
        //    //ViewData["Movie"] = movie;
        //    //ViewBag.RandomMovie = movie; 
        //    //var viewResult = new ViewResult();
        //    //viewResult.ViewData.Model
        //    //return View(movie);
        //    //return Content("Hello World ");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("Index","Home", new { page = 1 , sortBy="name" });
        //}
        //public ActionResult Edit (int movieID)
        //{
        //    return Content("id=" + movieID);
        //}
        ////movies
        //public ActionResult Index (int? pageIndex  , string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));   
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]

        //public ActionResult ByReleaseDate(int year , int month)
        //{
        //    return Content(year + "/" + month );
        //}
    }
}