using System.Collections.Generic;
using System.Linq;
using HookahsAndSmokingSystems.Database;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HookahsAndSmokingSystems.Models.Product
{
    public class SubCategoriesRepository : ISubCategoriesRepository
    {
        private ProductContext _productContext;

        public SubCategoriesRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IEnumerable<SubCategory> List => _productContext.SubCategories.Include(s => s.ParentCategory);
        
        public IEnumerable<string> GetListElementsName()
        {
            IEnumerable<string> names = List.Select(x => x.Name);
            return names;
        }
    }
}