using Pugcorn_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pugcorn_v1
{
    public class ProductService
    {
        private readonly DbPugcornContext _context;

        public ProductService(DbPugcornContext context)
        {
            _context = context;
        }
        public int Save(Product product)
        {
            _context.Add(product);
            return 1;
        }

        public List<Product> FindAll()
        {
            return _context.Products.ToList();
        }
    }
}
