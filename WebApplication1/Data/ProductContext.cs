using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace ProductCatalog.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
