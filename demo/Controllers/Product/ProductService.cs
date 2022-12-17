
namespace demo.Controllers.Product
{
    public class ProductService
    {
        public ProductService()
        {
            // The list of products is now initialized in the FindAll method
        }

        public List<Models.Product> FindAll()
        {
            List<Models.Product> products = new List<Models.Product>
            {
                new Models.Product { Id = 1, Title = "Product 1", Description = "Description of product 1", Price = 15},
                new Models.Product { Id = 2, Title = "Product 2", Description = "Description of product 2", Price = 40},
                new Models.Product { Id = 3, Title = "Product 3", Description = "Description of product 3", Price = 150}
            };


            return products;
        }
    }
}
