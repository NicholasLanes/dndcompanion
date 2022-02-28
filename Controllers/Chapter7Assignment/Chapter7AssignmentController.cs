using dnd.Models.User;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dnd.Controllers
{
    public class Chapter7AssignmentController : Controller
    {
        //import context from the database which stores user information
        private UserContext Context { get; set; }
        //pass that context object to the controller
        public Chapter7AssignmentController(UserContext ctx)
        {
            Context = ctx;
        }
        //Index route
        [Route("[controller]/[action]/{id?}")]
        public IActionResult Index()
        {
            //sends a list of the database objects (users/students) to a variable
            var students = Context.Users.OrderBy(m => m.UserId).ToList();
            return View();
        }
    }
}
