using Microsoft.EntityFrameworkCore;
using WebApp.Entitities;

namespace WebApp.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>
            contextOptions)
            : base(contextOptions)
        {

        }

        public DbSet <Product> Products { get; set; }
    }
}
