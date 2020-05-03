using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Zen.Business;
using Zen.Entities.Concrete;
using Zen.Mvc.Controllers;
using Zen.Mvc.Models;

namespace Zen.Mvc.Tests.Unit
{
    public class HomeControllerTest
    {
        private Mock<IProductService> _mockProductService;
        private List<Product> _fakeProducts;

        public HomeControllerTest()
        {
            _mockProductService = new Mock<IProductService>();
            _fakeProducts = new List<Product>()
            {
                new Product()
                {
                    ProductId  = 1,
                    ProductName  = "Table",
                    UnitPrice  = 100,
                    UnitsInStock  = 50
                },
                new Product()
                {
                    ProductId =  2,
                    ProductName = "Chair",
                    UnitPrice = 45,
                    UnitsInStock = 60
                }
            };
        }

        [Fact]
        public void Index_WhenExecutes_ReturnViewWithProductListViewModel()
        {
            var homeController = new HomeController(_mockProductService.Object);

            _mockProductService.Setup(proSer => proSer.GetAll()).Returns(_fakeProducts);

            var result = homeController.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.IsAssignableFrom<ProductListViewModel>(viewResult.Model);
        }
    }
}
