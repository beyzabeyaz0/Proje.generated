using Microsoft.AspNetCore.Mvc;

namespace Proje.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
