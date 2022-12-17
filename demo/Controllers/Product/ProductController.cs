
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace demo.Controllers.Product
{
    [Route("")]
    [ApiController]
    public class ProductController : Controller
    {

        private readonly ProductService productService;

        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("allProducts")]
        public List<Models.Product> GetAllProducts()
        {
              return productService.FindAll();
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = GetAllProducts();
            return View("_ProductList", products);
        }

    }
}
