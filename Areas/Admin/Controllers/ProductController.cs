using Microsoft.AspNetCore.Mvc;

namespace Module5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {

            return Content("List Admin Controller");

        }

        //defualt
        public IActionResult Add()
        {

            return Content("Add Admin Controller");
        }

        [Route("Update")]
        public IActionResult Update(int id)
        {

            return Content("Update Admin Controller");

        }

        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {

            return Content("Delete Admin Controller");

        }
    }
}

