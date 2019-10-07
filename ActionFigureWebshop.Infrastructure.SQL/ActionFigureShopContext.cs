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

     public DbSet<ActionFigure> ActionFigures { get; set; }
    }
}