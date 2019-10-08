using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionFigureWebshop.Core.ApplicationServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ActionFigureWebshop.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionFigureController : ControllerBase
    {
        private readonly IActionFigureService _actionFigureService;
        public ActionFigureController(IActionFigureService actionFigureService)
        {
            _actionFigureService = actionFigureService;
        }
        // GET api/ActionFigure
        [HttpGet]
        public ActionResult<IEnumerable<ActionFigure>> Get()
        {
            return _actionFigureService.ReadAllActionFigures();
        }

        // GET api/ActionFigure/5
        [HttpGet("{id}")]
        public ActionResult<ActionFigure> Get(int id)
        {
            return _actionFigureService.ReadActionFigure(id);
        }

        // POST api/ActionFigure  create
        [HttpPost]
        public ActionResult<ActionFigure> Post([FromBody] ActionFigure actionFigure)
        {
            try
            {
               return _actionFigureService.CreateActionFigure(actionFigure);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/ActionFigure/5 update
        [HttpPut("{id}")]
        public ActionResult<ActionFigure> Put(int id, [FromBody] ActionFigure actionFigure)
        {
            try
            {
                return Ok(_actionFigureService.UpdateActionFigure(actionFigure)); 
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // DELETE api/ActionFigure/5
        [HttpDelete("{id}")]
        public ActionResult<ActionFigure> Delete(int id)
        {
            try
            {
                // we are getting the action figure
                var actionfigure = _actionFigureService.ReadActionFigure(id);

                // we are deleting the action figure 
                return _actionFigureService.DeleteActionFigure(actionfigure);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
