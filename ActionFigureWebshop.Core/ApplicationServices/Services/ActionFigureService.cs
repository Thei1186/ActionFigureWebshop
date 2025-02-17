﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using ActionFigureWebshop.Core.DomainServices;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices.Services
{
    public class ActionFigureService: IActionFigureService
    {
        private readonly IActionFigureRepository _figureRepo;

        public ActionFigureService(IActionFigureRepository figureRepo)
        {
            _figureRepo = figureRepo;
        }

        public ActionFigure ReadActionFigure(int id)
        {
            return _figureRepo.GetActionFigureById(id);
        }

        public ActionFigure CreateActionFigure(ActionFigure figure)
        {
            if (figure == null)
            {
                throw new InvalidDataException("No figure was inserted");
            }

            return _figureRepo.Creat(figure);
        }

        public ActionFigure DeleteActionFigure(ActionFigure figure)
        {
            if (figure == null)
            {
                throw new InvalidDataException("No action figure was found");
            }
            return _figureRepo.Delete(figure);
        }

        public ActionFigure UpdateActionFigure(ActionFigure figure)
        {
            return _figureRepo.Update(figure);
        }

        public List<ActionFigure> ReadAllActionFigures()
        {
            return _figureRepo.ReadAll();
        }

        public List<ActionFigure> FilteredReadAllActionFigures(Filter filter)
        {
            if (filter.CurrentPage < 0 || filter.ItemsPrPage < 0)
            {
                throw new InvalidDataException("CurrentPage and ItemsPage Must be zero or more");
            }
            if ((filter.CurrentPage - 1 * filter.ItemsPrPage) >= _figureRepo.Count())
            {
                throw new InvalidDataException("Index out of bounds, CurrentPage is too high");
            }
            return _figureRepo.ReadAllFiltered(filter).ToList();
        }
    }
}