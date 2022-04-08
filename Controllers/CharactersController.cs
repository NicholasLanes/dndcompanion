using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dnd.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index(List<Character> characters)
        {
            if (ModelState.IsValid)
            {
                var session = new Session(HttpContext.Session);
                session.SetCharacters(characters);
            }
            return View();
        }
    }
}
