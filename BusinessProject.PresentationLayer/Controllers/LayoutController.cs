using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
