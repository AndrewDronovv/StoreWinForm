using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;

namespace Store.Domain
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<GroupRight> GroupRights { get; set; }
        //public DbSet<ProductCart> ProductCarts { get; set; }
        //public DbSet<Right> Rights { get; set; }
        //public DbSet<RightRole> RightRoles { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public AppDbContext()
        {
        }
    }
}
