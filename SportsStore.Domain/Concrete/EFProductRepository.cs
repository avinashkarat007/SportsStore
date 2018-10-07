using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace SportsStore.Domain.Concrete
{
    public class EFProductRepository : IProductsRepository
    {

        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products.ToList();
            }
        }
    }
}
