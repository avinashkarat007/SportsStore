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


        /*
        Data:
        
        CREATE TABLE [dbo].[Products] (
           [ProductID]   INT             IDENTITY (1, 1) NOT NULL,
           [Name]        NVARCHAR (100)  NOT NULL,
           [Description] NVARCHAR (500)  NOT NULL,
           [Category]    NVARCHAR (50)   NOT NULL,
           [Price]       DECIMAL (16, 2) NOT NULL,
           PRIMARY KEY CLUSTERED ([ProductID] ASC)
           );
           
           
           
           SET IDENTITY_INSERT [dbo].[Products] ON
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (1, N'Kayak', N'A boat for one person', N'WaterSports', CAST(275.00 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (4, N'Lifejacket', N'Protective and fashionable', N'WaterSports', CAST(48.95 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (5, N'Soccer Ball', N'FIFA-approved size and weight', N'Soccer', CAST(20.56 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (6, N'Corner Flags', N'Give your playing field a professional touch', N'Soccer', CAST(45.78 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (7, N'Thinking Cap', N'Improve your brain efficiency by 75%', N'Chess', CAST(15.88 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (8, N'Human Chess Board', N'A fun game for the family', N'Chess', CAST(29.47 AS Decimal(16, 2)))
           INSERT INTO [dbo].[Products] ([ProductID], [Name], [Description], [Category], [Price]) VALUES (9, N'Carroms Board', N'A fun game', N'Carroms', CAST(2500.00 AS Decimal(16, 2)))
           SET IDENTITY_INSERT [dbo].[Products] OFF
            
         */

    }
}