using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;


namespace dnd.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext Context { get; set; }
        public HomeController(CharacterContext ctx)
        {
            Context = ctx;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }
        public IActionResult CreateUser(User user)
        {
            // If there are no issues with validation
            if (ModelState.IsValid)
            {
                var session = new Session(HttpContext.Session);
                session.SetUser(user);
                Context.Users.Add(user); // add user to dbcontext
                Context.SaveChanges(); // save context changes
                // Returns user to the Characters view
                return View("Characters");
            }
            return View("CreateUser");
        }
        /*
         * Login Post action queries the database for a user with the same username
         * If the username and password match a single record in the database
         * it will store the user information for the session and return them
         * to the characters page where they can view and edit characters
         */
        [HttpGet]
        public IActionResult Login()
        {
            return View("Index");
        }
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
                // else there is a match, update session data and proceed to characters view
                else
                {
                    var session = new Session(HttpContext.Session);
                    session.SetUser(userAttempt);
                    return View("Characters");
                }
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult CreateCharacter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCharacter(Character character)
        {
            // If there are no issues with validation
            if (ModelState.IsValid)
            {
                Context.Characters.Add(character); // add user
                Context.SaveChanges(); // save user
                // Returns user to the Characters view
                return View("Characters");
            }
            return View("CreateCharacter");
        }
        public IActionResult Dice()
        {
            return View();
        }
    }
}
