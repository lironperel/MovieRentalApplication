using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalApplication.Entities;

namespace MovieRentalApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View("Admin");
        }

        public ActionResult Movies()
        {
            Movie mv = new Movie { movieID=1, movieName="Hi", description = "Bye", genre = "Action", year = 2016 };

            return View("Movies",mv);
        }
    }
}