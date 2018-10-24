using RentalVideo.ActionFilters;
using RentalVideo.Models;
using RentalVideo.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace RentalVideo.Controllers
{
    [CustomGlobalization]
    [CustomAuthorize]
    public class MovieController : Controller
    {
        MovieRepository repository = MovieRepository.GetInstance();
 
        // GET: Movie
        public ActionResult Index()
        {
            List<MovieModelView> movieList = repository.GetAllMovies();
            return View(movieList);            
        }

        // Get: Movie
        public ActionResult Create()
        {
            return View();
        }

        // Post Create
        [HttpPost]
        public ActionResult Create(MovieModelView model)
        {
            if (ModelState.IsValid)
            {
                repository.AddMovie(model);
                return RedirectToAction("Index");
                //Registro Exitoso de la película en la DB.
            }
            return View();
        }

        // Get Update
        public ActionResult Update(int movieId)
        {
            MovieModelView movie = repository.GetMovieById(movieId);

            return View(movie);
        }

        // Post Update
        [HttpPost]
        public ActionResult Update(MovieModelView model)
        {
            if(ModelState.IsValid)
            {
                repository.Updatemovie(model);
                return RedirectToAction("Index");
            }
            
            return View();
        }

        // Get Remove
        public ActionResult Remove(int movieId)
        {
            MovieModelView movie = repository.GetMovieById(movieId);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Remove(MovieModelView model)
        {
            repository.DeleteMovie(model.Id);
           return RedirectToAction("Index");
        }
    }
}