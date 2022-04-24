using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace dnd.Controllers
{
    public class CharactersController : Controller
    {
        private CharacterContext Context { get; set; }
        public CharactersController(CharacterContext ctx) { Context = ctx; }

        public IActionResult Index(string id)
        {
            // Grab all the characters from CharacterContext
            IQueryable<Character> query = 
                Context.Characters.Where(x => x.CharacterLevel > 0); 

            // Pass the query into a list of characters
            List<Character> characters = query.ToList();

            // Send these characters to the View
            return View(characters);
        }

        [HttpGet]
        public IActionResult CreateCharacter()
        {
            // These viewbag properties are for the dropdowns on the createcharacter sheet
            ViewBag.Alignments = Context.Alignments;
            ViewBag.Classes = Context.Classes;
            ViewBag.Races = Context.Races;
            return View();
        }
        // The CreateCharacter post action controls the addition of characters in the CreateCharacter view
        [HttpPost]
        public IActionResult CreateCharacter(Character character)
        {
            // If valid add the character to the db
            if (ModelState.IsValid)
            {
                Context.Characters.Add(character);
                Context.SaveChanges();
                return View("Index");
            }
            return View(character);
        }

        // The detail action allows the user to view all of the properties attributed to the selected character sheet
        public IActionResult Detail(int id)
        {
            // Grab all the characters from CharacterContext
            IQueryable<Character> query =
                Context.Characters.Where(x => x.CharacterLevel > 0 && x.CharacterId == id);

            // Assign the single query result to a character object
            Character character = query.SingleOrDefault();

            // Send this character to the view
            return View(character);

        }
        public IActionResult EditHealth(int id, int hp)
        {
            Character character = Context.Characters.Where(x => x.CharacterLevel > 0 && x.CharacterId == id).FirstOrDefault();
            if (ModelState.IsValid && character != null)
            {
                character.TemporaryHealth = hp;
                Context.Characters.Update(character);
                Context.SaveChanges();
                return View("Detail", character);
            }
            return RedirectToAction("Index");

        }
    }
}
