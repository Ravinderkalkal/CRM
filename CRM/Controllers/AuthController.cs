using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
