using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Zen.Business;
using Zen.Entities.Concrete;
using Zen.Mvc.Models;

namespace Zen.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IProductService _productService;

        private IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, IProductService productService, IMapper mapper)
        {
            _logger = logger;
            _productService = productService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };

            //var model = _mapper.Map<List<Product>, List<ProductListViewModel>>(products);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
