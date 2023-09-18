using Microsoft.AspNetCore.Mvc;

namespace PDriveUI.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
