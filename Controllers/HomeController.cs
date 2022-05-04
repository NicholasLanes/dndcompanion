using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Auth;
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
            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }

        public IActionResult Dice(int id)
        {
            Dice d = new Dice();
            Random r = new Random();
            d.rollResult = r.Next(1,12);
            return View("Dice",d);
        }
    }
}
