using Microsoft.AspNetCore.Mvc;

namespace MvcWork.Controllers
{
    public class CategoryController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}