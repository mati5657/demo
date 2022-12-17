using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace demo.Models
{
    [Route("")]
    [ApiController]
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }
    }
}
