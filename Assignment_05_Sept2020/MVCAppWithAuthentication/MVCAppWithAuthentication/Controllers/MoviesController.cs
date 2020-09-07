using MVCAppWithAuthentication.Models;
using MVCAppWithAuthentication.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppWithAuthentication.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Index()
        {
            //var mov = _context.movies.ToList();
            var mov = _context.movies.Include(g => g.General).ToList();
            return View(mov);
        }

        public ActionResult Create()
        {     
            var general = _context.Generals.ToList();
            var viewModel = new NewMoviesViewModel
            {
                VGenerals = general
            };
            return View(viewModel);
        }

        //[HttpPost]
        //public ActionResult Create(Movies mov) //Model Binding
        //{
        //    _context.movies.Add(mov);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index", "Movies");
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movies movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMoviesViewModel
                {
                    VGenerals = _context.Generals.ToList()
                };
                return View("Create", viewModel);
            }
            if (movie.Id == 0)
            {
                _context.movies.Add(movie);
            }
            else
            {



            }


            _context.SaveChanges();



            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new NewMoviesViewModel
            {
                //Id = movie.Id,
                //Name = movie.Name,
                //GenreId = movie.GenreId,
                VGenerals = _context.Generals.ToList()
            };
            return View("Create", viewModel);
        }
        public ActionResult DeleteM(int id)
        {
            var movieDel = _context.movies.Find(id);
            _context.movies.Remove(movieDel);
            _context.SaveChanges();
            return RedirectToAction("MovInd", "Movies");
        }
        public ActionResult MovDetails(int id)
        {
            var singleMovie = _context.movies.SingleOrDefault(c => c.Id == id);
            if (singleMovie == null)
                return HttpNotFound();
            return View(singleMovie);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }

    
}