using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopAdmin.Models;

public class PieShopDbContext :DbContext
{
    public PieShopDbContext(DbContextOptions<PieShopDbContext> options):base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Pie> Pies { get; set; }
}