using Microsoft.AspNetCore.Mvc;

namespace dnd.Controllers
{
    public class CreateCharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
