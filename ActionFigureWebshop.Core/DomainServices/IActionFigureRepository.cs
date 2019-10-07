using System.Collections.Generic;
using ActionFigureWebshop.Core.Entity;

namespace ActionFigureWebshop.Core.DomainServices
{
    public interface IActionFigureRepository
    {
        ActionFigure Creat(ActionFigure actionFigure);
        List<ActionFigure> ReadAll();

        ActionFigure GetActionFigureById(int id);

        ActionFigure Update(ActionFigure actionFigure);
        ActionFigure Delete(ActionFigure actionFigure);

    }
}