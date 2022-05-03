using System.Linq;
using HookahsAndSmokingSystems.Database;
using HookahsAndSmokingSystems.Models.Interfaces;
using HookahsAndSmokingSystems.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace HookahsAndSmokingSystems.Controllers.AdminPanelActionControllers
{
    public class ProductController : Controller
    {
        private ProductContext _productContext;
        
        private ISubCategoriesRepository _subCategoriesRepository;

        public ProductController(ProductContext productContext, ISubCategoriesRepository subCategoriesRepository)
        {
            _productContext = productContext;
            _subCategoriesRepository = subCategoriesRepository;
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View("~/Views/AdminPanel/Actions/AddProduct.cshtml", _subCategoriesRepository);
        }
        
        [HttpPost]
        public IActionResult Add(string name, string subCategory, string imageUrl, string description, string price)
        {
            if (name is null == true || imageUrl is null == true || description is null == true || price is null == true)
                return Add();
            
            Product product = new Product
            {
                Name = name,
                SubCategory = _productContext.SubCategories.FirstOrDefault(c => c.Name == subCategory),
                DisplayingImageUrl = imageUrl,
                Description = description,
                Price = price
            };

            _productContext.Add(product);
            _productContext.SaveChanges();
            
            return Add();
        }
    }
}