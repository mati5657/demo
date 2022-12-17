using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers.Product
{
    [Route("")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ProductService productService;

        public HomeController(ProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View("_ProductList", productService.FindAll());
        }
    }
}
