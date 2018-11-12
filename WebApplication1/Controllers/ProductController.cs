using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductsRepository repository;

        public int PageSize = 3;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        // GET: Product
        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(x => category == null ||  x.Category == category)
                    .OrderBy(x => x.Name)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null
                        ? repository.Products.Count()
                        : repository.Products
                            .Count(e => e.Category == category)
                },
                CurrentCategory = category
            };

            return View(model);
        }

        // THis is a comment.
        public FileContentResult GetImage(int productId)
        {
            var prod = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            return prod != null ? File(prod.ImageData, prod.ImageMimeType) : null;
        }
    }
}