using Microsoft.AspNetCore.Mvc;

namespace supermarket.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
