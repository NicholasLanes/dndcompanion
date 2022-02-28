using dnd.Models.User;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dnd.Controllers
{
    public class HomeController : Controller
    {
      
        private UserContext Context { get; set; }
        public HomeController(UserContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
        {
            var users = Context.Users.OrderBy(m => m.UserId).ToList();
            return View(users);
        }        
    }
}
