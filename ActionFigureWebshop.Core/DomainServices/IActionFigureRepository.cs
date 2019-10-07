using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.DomainServices
{
    public interface IActionFigureRepository
    {
        ActionFigure Creat(ActionFigure actionFigure);
        List<ActionFigure> readAll();

        ActionFigure GetActionFigureById(ActionFigure actionFigure);

        ActionFigure update(ActionFigure actionFigure);
        ActionFigure delete(ActionFigure actionFigure);

    }
}