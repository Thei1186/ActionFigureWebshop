using System.Collections.Generic;
using System.IO;
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

        public ActionFigure ReadActionFigure(ActionFigure figure)
        {
            return _figureRepo.GetActionFigureById(figure);
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
            return _figureRepo.readAll();
        }
    }
}