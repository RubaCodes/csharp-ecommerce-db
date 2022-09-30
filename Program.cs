using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

internal class ECommerceContext : DbContext {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilding)
    {
        optionsBuilding.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True");
    }


}