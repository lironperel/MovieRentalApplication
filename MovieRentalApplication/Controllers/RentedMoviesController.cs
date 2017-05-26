using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieRentalApplication.Entities;

namespace MovieRentalApplication.Controllers
{
    public class RentedMoviesController : Controller
    {
        private MovieRentalEntities db = new MovieRentalEntities();

        // GET: RentedMovies
        public ActionResult Index()
        {
            var rentedMovies = db.RentedMovies.Include(r => r.Movie).Include(r => r.User);
            return PartialView(rentedMovies.ToList());
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
