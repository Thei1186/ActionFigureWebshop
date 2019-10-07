using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.ApplicationServices
{
    public interface IActionFigureService
    {
        ActionFigure ReadActionFigure(ActionFigure figure);
        ActionFigure CreateActionFigure(ActionFigure figure);
        ActionFigure DeleteActionFigure(ActionFigure figure);
        ActionFigure UpdateActionFigure(ActionFigure figure);
        List<ActionFigure> ReadAllActionFigures();
    }
}