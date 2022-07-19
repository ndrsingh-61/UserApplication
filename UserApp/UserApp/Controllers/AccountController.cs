using Microsoft.AspNetCore.Mvc;

namespace UserApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
