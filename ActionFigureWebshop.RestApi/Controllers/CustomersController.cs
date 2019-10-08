using System;
using System.Collections.Generic;
using ActionFigureWebshop.Core.ApplicationServices;
using ActionFigureWebshop.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ActionFigureWebshop.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
       
        public CustomersController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        // GET api/ActionFigure
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return _customerService.ReadAllCustomer();
        }

        // GET api/ActionFigure/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _customerService.ReadCustomer(id);
        }

        // POST api/ActionFigure  create
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer cust)
        {
            try
            {
                return _customerService.CreateCustomer(cust);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/ActionFigure/5 update
        [HttpPut("{id}")]
        public ActionResult<Customer> Put(int id, [FromBody] Customer cust)
        {
            try
            {
                return Ok(_customerService.UpdateCustomer(cust));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // DELETE api/ActionFigure/5
        [HttpDelete("{id}")]
        public ActionResult<Customer> Delete(int id)
        {
            try
            {
                // we are getting the action figure
                var customer = _customerService.ReadCustomer(id);

                // we are deleting the action figure 
                return _customerService.DeleteCustomer(customer);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}