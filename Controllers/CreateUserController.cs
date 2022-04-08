using dnd.Models;
using dnd.Models.Session;
using Microsoft.AspNetCore.Mvc;

namespace dnd.Controllers
{
    public class CreateUserController : Controller
    {
        private CharacterContext context;
        public CreateUserController(CharacterContext ctx) { this.context = ctx; }
        [Route("CreateUser/")]
        public IActionResult Index(User user)
        {
            // If there are no issues with validation
            if (ModelState.IsValid)
            {
                context.Users.Add(user); // add user to dbcontext
                context.SaveChanges(); // save context changes
                // Returns user to the Characters view
                return View("Characters");
            }
            return View("CreateUser");
        }
    }
}
