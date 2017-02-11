using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Financeira.Domain.Interfaces.Services;
using Financeira.Domain.Entities;
using Financeira.Domain.Validation;
using Financeira.WebApi.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Financeira.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BusinessController : Controller
    {
        protected readonly IBusinessService _business;
        private BusinessValidator _businessValidator = new BusinessValidator();
        public BusinessController(IBusinessService business)
        {
            _business = business ;
        }
        // GET api/values
        [HttpGet]
        public ObjectResult Get([FromQuery] ModelViewFilter filter)
        {
            try{
                if(filter.Start != null  && filter != null){
                    return Ok(_business.GetAllByPeriod(filter.Start, filter.End, filter.IsGroup));
                }
                return Ok(_business.GetAll(filter.IsGroup));
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ObjectResult Get(int id)
        {
            try
            {   
                var business = _business.Get(id);
                if(business != null)
                {
                    return Ok(business);
                }else 
                {
                    return NotFound(business);
                }
                
            }catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
        }

        // POST api/values
        [HttpPost]
        public ObjectResult Post([FromBody]Business business)
        {
            var validate = _businessValidator.Validate(business);
            if(validate.IsValid)
            {
                _business.Add(business);
                return Ok(business);
            }
            return BadRequest(validate.Errors);
        }

        // PUT api/values/5
        [HttpPut]
        public ObjectResult Put([FromBody]Business business)
        {
            var validate = _businessValidator.Validate(business);
            if(validate.IsValid)
            {
                _business.Edit(business);
                return Ok(business);
            }
            return BadRequest(validate.Errors);
        }

        // DELETE api/values/
        [HttpDelete]
        public ObjectResult Delete([FromBody] IList<Business> business)
        {
            try
            {
                _business.DeleteAll(business);
                return Ok(business.Count);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}
