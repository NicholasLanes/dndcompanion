using dnd.Models;
using dnd.Models.Characters;
using dnd.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using dnd.Models.Alignments;
using dnd.Models.Classes;
using dnd.Models.Races;

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

            /*
             * This section is a workaround, there was an issue
             * where the select lists were passing an integer which
             * is the id of the selected alignment as the name(aka value).
             * This includes a simple integer check and will update the
             * database to the correct values if it encounters any of
             * these instances
             */ 

            // Declaring lists of potentially bugged properties
            List<Alignment> alignments = Context.Alignments.ToList();
            List<Class> classes = Context.Classes.ToList();
            List<Race> races = Context.Races.ToList();

            // for every character found in our query
            foreach (Character character in characters)
            {
                // this defaults to false so we don't spend time updating the context if all the values are accurate
                bool isInteger = false;

                // If the alignment comes back as int, sets isInteger == true
                isInteger = int.TryParse(character.Alignment, out int i);
                if(isInteger == true)
                {
                    Alignment alignment = new Alignment(); // Declare
                    alignment = alignments.Where(x => x.Id == i).FirstOrDefault(); // Query
                    character.Alignment = alignment.Name; // Assign
                    Context.Characters.Update(character); // Update/Replace
                    Context.SaveChangesAsync(); // Save
                }

                // If the class comes back as int, sets isInteger == true
                isInteger = int.TryParse(character.CharacterClass, out i);
                if (isInteger == true)
                {
                    Class c = new Class(); // Declare
                    c = classes.Where(x => x.Id == i).FirstOrDefault(); // Query
                    character.CharacterClass = c.Name; // Assign
                    Context.Characters.Update(character); // Update/Replace
                    Context.SaveChangesAsync(); // Save
                }

                // If the race comes back as int, sets isInteger == true
                isInteger = int.TryParse(character.CharacterRace, out i);
                if (isInteger == true)
                {
                    Race r = new Race(); // Declare
                    r = races.Where(x => x.Id == i).FirstOrDefault(); // Query
                    character.CharacterRace = r.Name; // Assign
                    Context.Characters.Update(character); // Update/Replace
                    Context.SaveChangesAsync(); // Save
                }
            }
            // Send these characters to the View
            return View(characters);
        }

        [HttpGet]
        public IActionResult CreateCharacter()
        {
            // These viewbag properties are for the dropdowns on the createcharacter sheet
            ViewBag.Alignments = Context.Alignments.ToList();
            ViewBag.Classes = Context.Classes.ToList();
            ViewBag.Races = Context.Races.ToList();
            ViewBag.Abilities = Context.Abilities.ToList();
            ViewBag.Skills = Context.Skills.ToList();
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
                return View("Detail", character);
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
        public IActionResult EditXP(int id, int xp)
        {
            Character character = Context.Characters.Where(x => x.CharacterLevel > 0 && x.CharacterId == id).FirstOrDefault();
            if (ModelState.IsValid && character != null)
            {
                character.ExperiencePoints = xp;
                Context.Characters.Update(character);
                Context.SaveChanges();
                return View("Detail", character);
            }
            return RedirectToAction("Index");

        }
        public IActionResult DeleteCharacter(int id)
        {
            Character character = Context.Characters.Where(x => x.CharacterLevel > 0 && x.CharacterId == id).FirstOrDefault();
            if (ModelState.IsValid && character != null)
            {
                Context.Characters.Remove(character);
                Context.SaveChanges();
                IQueryable<Character> query =
                Context.Characters.Where(x => x.CharacterLevel > 0);
                List<Character> characters = query.ToList();
                return View("Index", characters);
            }
            return RedirectToAction("Index");
        }
    }
}
