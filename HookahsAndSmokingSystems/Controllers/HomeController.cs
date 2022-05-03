using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HookahsAndSmokingSystems.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HookahsAndSmokingSystems.Models;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace HookahsAndSmokingSystems.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductContext _productContext;

        public HomeController(ILogger<HomeController> logger, ProductContext productContext)
        {
            _logger = logger;
            _productContext = productContext;
        }

        public IActionResult Index()
        {
            Dictionary<SubCategory, List<Product>> dictionary = new Dictionary<SubCategory, List<Product>>();
            
            foreach (var subCategory in _productContext.SubCategories)
                dictionary.Add(subCategory, _productContext.Products.Where(p => p.SubCategory == subCategory).ToList());

            return View(dictionary);
        }

        public IActionResult MoreAtProduct(int id)
        {
            Product product = _productContext.Products.First(p => p.Id == id);
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}