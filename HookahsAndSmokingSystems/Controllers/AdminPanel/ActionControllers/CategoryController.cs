using HookahsAndSmokingSystems.Database;
using HookahsAndSmokingSystems.Models.Categoty;
using Microsoft.AspNetCore.Mvc;

namespace HookahsAndSmokingSystems.Controllers.AdminPanelActionControllers
{
    public class CategoryController : Controller
    {
        private ProductContext _productContext;

        public CategoryController(ProductContext productContext)
        {
            _productContext = productContext;
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View("~/Views/AdminPanel/Actions/AddCategory.cshtml");
        }

        [HttpPost]
        public IActionResult Add(string name)
        {
            if (name is null == true)
                return Add();

            Category category = new Category {Name = name};

            _productContext.Add(category);
            _productContext.SaveChanges();

            return Add();
        }
    }
}