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

        public ActionFigure delete(ActionFigure actionFigure)
        {
            var actionFigureToRemoved = _ShopContext.Remove(actionFigure).Entity;
            _ShopContext.SaveChanges();
            return actionFigureToRemoved;
        }

        public ActionFigure GetActionFigureById(ActionFigure actionFigure)
        {
            return _ShopContext.ActionFigures.FirstOrDefault(af=> af.Id== actionFigure.Id);
        }


        public List<ActionFigure> readAll()
        {
            return _ShopContext.ActionFigures.ToList();
        }

        public ActionFigure update(ActionFigure actionFigure)
        {
            _ShopContext.Attach(actionFigure).State = EntityState.Modified;
            _ShopContext.SaveChanges();
            return actionFigure;
        }
    }
}