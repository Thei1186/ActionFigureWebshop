using System.Dynamic;
using ActionFigureWebshop.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActionFigureWebshop.Infrastructure.SQL
{
    public class ActionFigureShopContext: DbContext
    {
     public ActionFigureShopContext(DbContextOptions opt): base(opt)
     {
         
     }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderLine>().HasKey(ol => new { ol.ActionFigureId, ol.OrderId });

            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.ActionFigure)
                .WithMany(a => a.OrderLines);
            modelBuilder.Entity<OrderLine>()
                .HasOne(ol => ol.Order)
                .WithMany(o => o.OrderLines);
        }
     public DbSet<ActionFigure> ActionFigures { get; set; }
     public DbSet<Order> Orders { get; set; }
     public DbSet<Customer> Customers { get; set; }
    }
}