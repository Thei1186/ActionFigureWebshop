using System;
using System.Collections.Generic;
using ActionFigureWebshop.Core.ApplicationServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ActionFigureWebshop.RestApi.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET api/Orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return _orderService.ReadAllOrders();
        }

        // GET api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return _orderService.ReadOrder(id);
        }

        // POST api/Orders  create
        [HttpPost]
        public ActionResult<Order> Post([FromBody] Order order)
        {
            try
            {
                return _orderService.CreateOrder(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/Orders/5 update
        [HttpPut("{id}")]
        public ActionResult<Order> Put(int id, [FromBody] Order order)
        {
            try
            {
                return Ok(_orderService.UpdateOrder(order));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // DELETE api/Orders/5
        [HttpDelete("{id}")]
        public ActionResult<Order> Delete(int id)
        {
            try
            {
                // we are getting the action figure
                var order = _orderService.ReadOrder(id);

                // we are deleting the action figure 
                return _orderService.DeleteOrder(order);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}