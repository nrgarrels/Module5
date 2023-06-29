using Microsoft.AspNetCore.Mvc;

namespace Module5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // maps to /Areas/Admin/Views/Home/Index.cshtml
        }
    }
}

