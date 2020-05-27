using Microsoft.EntityFrameworkCore;

namespace Solution
{
    class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Superuser> Superusers { get; set; }
    }
}