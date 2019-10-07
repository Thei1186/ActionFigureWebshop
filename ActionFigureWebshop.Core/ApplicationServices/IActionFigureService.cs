using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices
{
    public interface IActionFigureService
    {
        ActionFigure ReadActionFigure(int id);
        ActionFigure CreateActionFigure(ActionFigure figure);
        ActionFigure DeleteActionFigure(ActionFigure figure);
        ActionFigure UpdateActionFigure(ActionFigure figure);
        List<ActionFigure> ReadAllActionFigures();
    }
}