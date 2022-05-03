using System.Collections.Generic;
using System.Linq;
using HookahsAndSmokingSystems.Database;
using HookahsAndSmokingSystems.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HookahsAndSmokingSystems.Models.Categoty
{
    public class CategoryRepository : ICategoryRepository
    {
        private ProductContext _productContext;

        public CategoryRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IEnumerable<Category> List => _productContext.Categories;
        
        public IEnumerable<string> GetListElementsName()
        {
            IEnumerable<string> names = List.Select(x => x.Name);
            return names;
        }
    }
}