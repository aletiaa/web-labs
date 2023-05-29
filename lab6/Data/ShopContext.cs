using Microsoft.EntityFrameworkCore;

public class ShopContext : DbContext
{
    public ShopContext()
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ShopDB;Trusted_Connection=True;Encrypt=False");
    }
}