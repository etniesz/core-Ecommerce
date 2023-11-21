using Microsoft.EntityFrameworkCore;

namespace Ecom.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductsCategories> products_has_categories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<ProductsOrders> products_has_orders { get; set; }
        public DbSet<CustomersOrders> customers_has_orders { get; set; }
    }
}