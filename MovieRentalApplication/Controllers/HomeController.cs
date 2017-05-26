using System.Web.Mvc;
using MovieRentalApplication.Entities;
using System.Linq;

namespace MovieRentalApplication.Controllers
{
    public class HomeController : Controller
    {
        private MovieRentalEntities mv = new MovieRentalEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(mv.Movies);
        }
        

        public ActionResult Admin()
        {
            //MovieRentalEntities mv = new MovieRentalEntities();

            return View("Admin");
        }

        public ActionResult About()
        {
            //MovieRentalEntities mv = new MovieRentalEntities();

            return View("About");
        }

        public ActionResult View_MovieDetails(int id)
        {
            var movie = mv.Movies.Find(id);

            return PartialView("~/Views/Movies/_MovieDetails.cshtml", movie); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Rent_MovieDetails(int id,string fullname, string credit)
        {
            if (ModelState.IsValid)
            {

                User tempUser = null;

                tempUser = mv.Users.FirstOrDefault(u => u.name == fullname);

                if (tempUser == null)
                {
                    tempUser = mv.Users.Add(new User { name = fullname, creditcard = credit });
                    mv.SaveChanges();
                    tempUser = mv.Users.FirstOrDefault(u => u.name == fullname);
                }

                Movie tempMovie = mv.Movies.Find(id);

                mv.RentedMovies.Add(new RentedMovie { Movie = tempMovie, User = tempUser });
                mv.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}