using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{ 
    [Route("Retail/[controller]/[action]/{id?}")]
    public class ProductController : Controller
    {
        public IActionResult List(string id = "All")
        {
            return Content("Product controller, List action, Category: " + id);
        }
        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, ID: " + id);
        }
    }
}


