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

        public Product DeleteProduct(int productID)
        {
            Product prod = context.Products.FirstOrDefault(x => x.ProductID == productID);

            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
            }

            return prod;
        }

        public void saveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                context.Products.Add(product);
            }
            else
            {
                Product prod = context.Products.FirstOrDefault(x => x.ProductID == product.ProductID);
                if (prod != null)
                {
                    prod.Name = product.Name;
                    prod.Description = product.Description;
                    prod.Price = product.Price;
                    prod.Category = product.Category;
                    prod.ImageData = product.ImageData;
                    prod.ImageMimeType = product.ImageMimeType;
                }
            }
            context.SaveChanges();
        }
    }
}
