using dnd.Models;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dnd.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext Context { get; set; }
        public HomeController(CharacterContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*
         * Login Post action queries the database for a user with the same username
         * If the username and password match a single record in the database
         * it will store the user information for the session and return them
         * to the characters page where they can view and edit characters
         */
        [HttpPost]
        public IActionResult Login(User userAttempt)
        {
            // check for validation errors and proceed only if there are none
            if (ModelState.IsValid)
            {
                // querying dbcontext to find matching user
                IQueryable<User> query =
                    (from user in Context.Users
                    where user.Username == userAttempt.Username
                    && user.Password == userAttempt.Password
                    select user);
                // if query doesn't find a user, return to index
                if (query.Count() < 1)
                {
                    return View("Index");
                }
                // if query finds more than one user (this should not happen), return to index
                else if (query.Count() > 1)
                {
                    return View("Index");
                }
                // else proceed to characters view
                else
                {
                    return View("Characters");
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Characters()
        {
            return View();
        }
        public IActionResult Dice()
        {
            return View();
        }
    }
}
