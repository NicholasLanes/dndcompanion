using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;

namespace dnd.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext Context { get; set; }
        public HomeController(CharacterContext ctx) { Context = ctx; }

        public IActionResult Index(string id)
        {
            IQueryable<User> query = Context.Users.AsQueryable(); // query = all users in dbcontext
            IEnumerable<User> users = query.AsEnumerable();
            return View(users);
        }


        // Create User Get Result
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }
        // Create User Post Result
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                var session = new Session(HttpContext.Session);
                session.SetUser(user);
                Context.Users.Add(user);
                Context.SaveChanges();
                return View("Characters");
            }
            return View("CreateUser");
        }

        // Login Get Result
        [HttpGet]
        public IActionResult Login()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Login(User userAttempt)
        {
            if (ModelState.IsValid)
            {
                // querying dbcontext to find matching user
                IQueryable<User> query = Context.Users.Where(
                    x => x.Username == userAttempt.Username &&
                    x.Password == userAttempt.Password);

                var session = new Session(HttpContext.Session);
                session.SetUser(query.FirstOrDefault());
                ViewBag.ActiveUser = session.GetUser();
                ViewData["DisplayNone"] = "";
                ViewData["DisplayFormNone"] = "none";
                return RedirectToAction("Characters/Index");
            }
            else
            {
                ViewData["DisplayNone"] = "none";
                ViewData["DisplayFormNone"] = "";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Logout()
        {
            ViewBag.LoggedIn = false;
            ViewData["DisplayNone"] = "none";
            ViewData["DisplayFormNone"] = "";
            var session = new Session(HttpContext.Session);
            session.RemoveSessionData();
            return View("Index");
        }

        public IActionResult Dice()
        {
            return View();
        }
    }
}
