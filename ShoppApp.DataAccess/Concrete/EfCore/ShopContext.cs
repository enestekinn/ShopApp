using Microsoft.EntityFrameworkCore;
using ShoppAp.Entity;

namespace ShoppApp.DataAccess.Concrete.EfCore
{
    public class ShopContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=shopDb");
        }
      

    }
}