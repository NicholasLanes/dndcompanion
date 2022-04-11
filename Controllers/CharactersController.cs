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

        // The Index action controls the Characters main page of the website
        public IActionResult Index()
        {

            var session = new Session(HttpContext.Session);
            // Query Database, Filtering out null charactername results (dummy records in SQL database)
            IQueryable<Character> query = Context.Characters.Where(x => x.CharacterName != null);
            if (query.Any())
            {
                session.SetCharacterList(query.ToList());
                return View(query.ToList());
            }
            return View("Index");
        }

        // The CreateCharacter action controls the addition of characters in the CreateCharacter view
        public IActionResult CreateCharacter(CharacterListViewModel characterListView)
        {
            // These viewbag properties are for the dropdowns on the createcharacter sheet
            ViewBag.Alignments = Context.Alignments;
            ViewBag.Classes = Context.Classes;
            ViewBag.Races = Context.Races;
            // If valid add the character to the db
            if (ModelState.IsValid && characterListView.Character is not null)
            {
                Context.Characters.Add(characterListView.Character);
                Context.SaveChanges();
                return View("Index");
            }
            return View("CreateCharacter");
        }

        // The detail action allows the user to view all of the properties attributed to the selected character sheet
        public IActionResult Detail(string id)
        {
            var session = new Session(HttpContext.Session);
            IQueryable<Character> query = Context.Characters
            .Where(x => x.CharacterId == int.Parse(id));
            session.SetActiveCharacter(query.FirstOrDefault());
            return View(query.FirstOrDefault());
        }
    }
}
