using System.Collections.Generic;
using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Product;

namespace HookahsAndSmokingSystems.Models.Interfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<string> GetListElementsName();
        public IEnumerable<Category> List { get; }
    }
}