using Microsoft.AspNetCore.Mvc;
using ECommerceMVCFiltersApp.Filters;

namespace ECommerceMVCFiltersApp.Controllers
{
    [ServiceFilter(typeof(LoggingFilter))]
    [ServiceFilter(typeof(AuthFilter))]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product List Page");
        }

        public IActionResult Details()
        {
            return Content("Product Details Page");
        }

        public IActionResult ErrorTest()
        {
            throw new Exception("Test Exception");
        }
    }
}