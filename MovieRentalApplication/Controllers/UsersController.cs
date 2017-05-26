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
    public class UsersController : Controller
    {
        private MovieRentalEntities db = new MovieRentalEntities();

        // GET: Users
        public ActionResult Index()
        {
            return PartialView(db.Users.ToList());
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
