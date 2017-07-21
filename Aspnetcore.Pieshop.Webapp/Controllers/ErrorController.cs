using Microsoft.AspNetCore.Mvc;

namespace Aspnetcore.Pieshop.Webapp.Controllers
{
    public class ErrorController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}