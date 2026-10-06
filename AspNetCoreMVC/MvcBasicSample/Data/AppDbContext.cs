using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Models;


namespace MvcBasicSample.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
      :base(options)  {

        }

        public DbSet<Product> Products => Set<Product>();
    }
}
