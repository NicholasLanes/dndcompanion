using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace dnd.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext Context { get; set; }
        public HomeController(CharacterContext ctx)
        {
            Context = ctx;
        }

        // Index Result Logic
        public IActionResult Index(string id)
        {
            ViewBag.Abilities = Context.Abilities;
            ViewBag.Alignments = Context.Alignments;
            ViewBag.Classes = Context.Classes;
            ViewBag.Races = Context.Races;
            ViewBag.Skills = Context.Skills;
            return View("Index");
        }

        // Characters Result Logic
        public IActionResult Characters()
        {
            ViewBag.Abilities = Context.Abilities;
            ViewBag.Alignments = Context.Alignments;
            ViewBag.Classes = Context.Classes;
            ViewBag.Races = Context.Races;
            ViewBag.Skills = Context.Skills;
            IQueryable<Character> query = Context.Characters;
            ViewBag.Characters = query;
            if (query.Count() > 0)
            {
                query = query.Where(t => t.CharacterId.ToString() != "");
            }
            var characters = query.ToList();
            return View(characters);
        }

        // CreateCharacter Result Logic
        [HttpGet]
        public IActionResult CreateCharacter()
        {
            ViewBag.Abilities = Context.Abilities;
            ViewBag.Alignments = Context.Alignments;
            ViewBag.Characters = Context.Characters;
            ViewBag.Classes = Context.Classes;
            ViewBag.Races = Context.Races;
            ViewBag.Skills = Context.Skills;
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

        // CreateUser Result Logic
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

        // Login Result Logic
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
                    return RedirectToAction("Index");
                }
                // if query finds more than one user (this should not happen), return to index
                else if (query.Count() > 1)
                {
                    return RedirectToAction("Index");
                }
                // else there is a match, update session data and proceed to characters view
                else
                {
                    var session = new Session(HttpContext.Session);
                    session.SetUser(userAttempt);
                    return RedirectToAction("Characters");
                }
            }
            return RedirectToAction("Index");
        }
        
        public IActionResult Dice()
        {
            return View();
        }
    }
}
