using System.Linq;
using HookahsAndSmokingSystems.Database;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HookahsAndSmokingSystems.Controllers.AdminPanelActionControllers
{
    public class SubCategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;
        private ProductContext _productContext;

        public SubCategoryController(ProductContext productContext, ICategoryRepository categoryRepository)
        {
            _productContext = productContext;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("~/Views/AdminPanel/Actions/AddSubCategory.cshtml", _categoryRepository);
        }

        [HttpPost]
        public IActionResult Add(string name, string categoryName)
        {
            if (name is null == true || categoryName is null == true)
                return Add();

            Category category = _productContext.Categories.FirstOrDefault(c => c.Name == categoryName);

            SubCategory subCategory = new SubCategory
            {
                Name = name,
                ParentCategory = category
            };

            _productContext.Add(subCategory);
            _productContext.SaveChanges();

            return Add();
        }
    }
}