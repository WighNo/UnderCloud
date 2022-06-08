using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HookahsAndSmokingSystems.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HookahsAndSmokingSystems.Models;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Interfaces;
using HookahsAndSmokingSystems.Models.Product;

namespace HookahsAndSmokingSystems.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ProductContext _productContext;

        private ISubCategoriesRepository _subCategoriesRepository;
        
        public HomeController(ILogger<HomeController> logger, ProductContext productContext, ISubCategoriesRepository subSubCategoriesesRepository)
        {
            _logger = logger;
            _productContext = productContext;
            _subCategoriesRepository = subSubCategoriesesRepository;
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
            product.SubCategoriesRepository = _subCategoriesRepository;
            return View(product);
        }
        
        [HttpPost]
        public IActionResult MoreAtProduct(string newStatusName, string productId)
        {
            Console.WriteLine(newStatusName);
            Console.WriteLine(productId);
            
            var dbProduct = _productContext.Products.First(p => p.Id == int.Parse(productId));
            
            dbProduct.Status = newStatusName;
            dbProduct.SubCategory = _subCategoriesRepository.List.FirstOrDefault(x => x.Name == newStatusName);

            _productContext.SaveChanges();
            
            Product product = _productContext.Products.First(p => p.Id == int.Parse(productId));
            product.SubCategoriesRepository = _subCategoriesRepository;
            
            return View(product);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}