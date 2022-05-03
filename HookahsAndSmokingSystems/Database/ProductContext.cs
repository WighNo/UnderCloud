using HookahsAndSmokingSystems.Models.Categoty;
using HookahsAndSmokingSystems.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace HookahsAndSmokingSystems.Database
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
        }
        
        public DbSet<Product> Products { get; private set; }
        public DbSet<Category> Categories { get; private set; }
        public DbSet<SubCategory> SubCategories { get; private set; }
    }
}