using System.Collections.Generic;
using System.Security.AccessControl;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Product;

namespace HookahsAndSmokingSystems.Models.Interfaces
{
    public interface ISubCategoriesRepository
    {
        public IEnumerable<SubCategory> List { get; }
        public IEnumerable<string> GetListElementsName();
    }
}