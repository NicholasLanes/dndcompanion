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

        // Index Result Logic (Home Page)
        public IActionResult Index()
        {
            return View("Index");
        }

        // Characters Result Logic (List of Existing Characters Page)
        public IActionResult Characters()
        {
            List<Character> characters = Context.Characters.ToList();
            var session = new Session(HttpContext.Session);
            IQueryable<Character> query = Context.Characters;
            if (query.Any())
            {
                session.SetCharacterList(query.ToList());
                return View(query.ToList());
            }
            return View();
        }

        // Create Character Get Result
        [HttpGet]
        public IActionResult CreateCharacter()
        {
            ViewData["Abilities"] = Context.Abilities;
            ViewData["Alignments"] = Context.Alignments;
            ViewData["Characters"] = Context.Characters;
            ViewData["Classes"] = Context.Classes;
            ViewData["Races"] = Context.Races;
            ViewData["Skills"] = Context.Skills;
            return View();
        }
        // Create Character Post Result
        [HttpPost]
        public IActionResult CreateCharacter(Character character)
        {
            if (ModelState.IsValid)
            {
                Context.Characters.Add(character);
                Context.SaveChanges();
                return View("Characters");
            }
            return View("CreateCharacter");
        }

        
        public IActionResult Detail(string id)
        {
            var session = new Session(HttpContext.Session);
            IQueryable<Character> query = Context.Characters
            .Where(x => x.CharacterId == Int32.Parse(id));
            session.SetActiveCharacter(query.FirstOrDefault());
            return View(query.FirstOrDefault());
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
                IQueryable<User> query =
                    (from user in Context.Users
                     where user.Username == userAttempt.Username
                     && user.Password == userAttempt.Password
                     select user);

                if (query.Count() != 1)
                {
                    return RedirectToAction("Index");
                }

                var session = new Session(HttpContext.Session);
                session.SetUser(userAttempt);
                return RedirectToAction("Characters");

            }
            return RedirectToAction("Index");
        }

        public IActionResult Dice()
        {
            return View();
        }
    }
}
