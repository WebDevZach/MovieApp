using Microsoft.AspNetCore.Mvc;
using MovieList.Models;
using Microsoft.EntityFrameworkCore;


namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext context { get; set; }

        //Constructor takes in a MoviesContext parameter and assigns that value to context
        //Example of dependency injection 
        public HomeController(MoviesContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Movies";

            //Sorts a collection of objects based on the title property of each object.
            //M represents each element in the list 
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.title).ToList();
            return View(movies); // returns view assicoated with the action name (index.cshtml)
        }
    }
}
