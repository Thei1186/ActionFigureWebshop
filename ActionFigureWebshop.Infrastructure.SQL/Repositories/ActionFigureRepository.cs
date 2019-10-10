using System;
using System.Collections.Generic;
using System.Linq;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace ActionFigureWebshop.Infrastructure.SQL.Repositories
{
    public class ActionFigureRepository : IActionFigureRepository
    {
        // interface fra database
        private readonly ActionFigureShopContext _ShopContext;


        public ActionFigureRepository(ActionFigureShopContext shopContext)
        {
            _ShopContext = shopContext;
        }

        public ActionFigure Creat(ActionFigure actionFigure)
        {
            _ShopContext.Attach(actionFigure).State = EntityState.Added;
            _ShopContext.SaveChanges();
            return actionFigure;
        }

        public ActionFigure Delete(ActionFigure actionFigure)
        {
            var actionFigureToRemoved = _ShopContext.Remove(actionFigure).Entity;
            _ShopContext.SaveChanges();
            return actionFigureToRemoved;
        }

        public int Count()
        {
            return _ShopContext.ActionFigures.Count();
        }

        public List<ActionFigure> ReadAllFiltered(Filter filter)
        {
            return _ShopContext.ActionFigures.Skip((filter.CurrentPage - 1) * filter.ItemsPrPage)
                .Take(filter.ItemsPrPage).ToList();
        }

        public ActionFigure GetActionFigureById(int id)
        {
            return _ShopContext.ActionFigures.FirstOrDefault(af=> af.Id== id);
        }


        public List<ActionFigure> ReadAll()
        {
            return _ShopContext.ActionFigures.ToList();
        }

        public ActionFigure Update(ActionFigure actionFigure)
        {
           var oldA= _ShopContext.ActionFigures.FirstOrDefault(a => a.Id == actionFigure.Id);
          // _ShopContext.ActionFigures.Attach(actionFigure).State = EntityState.Modified;
              oldA.Color = actionFigure.Color;
             oldA.Material = actionFigure.Material;
             oldA.Name = actionFigure.Name;
             oldA.PathImage = actionFigure.PathImage;
             oldA.Price = actionFigure.Price;
             oldA.Size = actionFigure.Size;
             oldA.Weight = actionFigure.Weight;

            _ShopContext.SaveChanges();
            return actionFigure;
        }
    }
}