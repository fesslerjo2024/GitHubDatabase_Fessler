using Microsoft.AspNetCore.Mvc;

namespace GitHubPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "PortalLinks");
        }
    }
}
