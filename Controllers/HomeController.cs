using dnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dnd.Controllers
{
    public class HomeController : Controller
    {
      
        private CharacterContext Context { get; set; }
        public HomeController(CharacterContext ctx)
        {
            Context = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult Characters()
        {
            return View();
        }
        public IActionResult Dice()
        {
            return View();
        }
    }
}
