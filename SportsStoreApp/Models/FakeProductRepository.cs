using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreApp.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name = "pr1", Price = 5},
            new Product {Name = "pr2", Price = 14},
            new Product {Name = "pr3", Price = 25},
            new Product {Name = "pr4", Price = 55},
        }.AsQueryable<Product>();
    }
}
