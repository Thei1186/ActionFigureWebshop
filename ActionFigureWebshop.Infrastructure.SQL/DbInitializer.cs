using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Infrastructure.SQL
{
    public class DbInitializer
    {
        public static void SeedDB(ActionFigureShopContext context)
        {
            context.Database.EnsureCreated();

            ActionFigure a1 = new ActionFigure
            {
                Name = "Hulk",
                Color = "Green",
                Material = "Plastic",
                Price = 35.00,
                Size = 40,
                Weight = 50
            };

            ActionFigure a2 = new ActionFigure
            {
                Name = "Hulk",
                Color = "Pink",
                Material = "Plastic",
                Price = 50.00,
                Size = 60,
                Weight = 80
            };

            ActionFigure a3 = new ActionFigure
            {
                Name = "Thor",
                Color = "Grey",
                Material = "Metal",
                Price = 55.00,
                Size = 20,
                Weight = 50
            };

            ActionFigure a4 = new ActionFigure
            {
                Name = "Hulk",
                Color = "Green",
                Material = "Plastic",
                Price = 35.00,
                Size = 20,
                Weight = 15
            };
            ActionFigure a5 = new ActionFigure
            {
                Name = "Batman",
                Color = "Pink",
                Material = "russik atom rester",
                Price = 50.00,
                Size = 60,
                Weight = 80
            };

            ActionFigure a6 = new ActionFigure
            {
                Name = "Batman",
                Color = "blue",
                Material = "russik atom rester",
                Price = 150.00,
                Size = 300,
                Weight = 18000
            };

            context.ActionFigures.AddRange(a1,a2,a3,a4,a5,a6);
            context.SaveChanges();
        }
    }
}