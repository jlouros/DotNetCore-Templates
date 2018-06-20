using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice.Generic.v2.Validation;
using Microservice.Generic.v2.Validation.Impl;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Generic.v2.Controllers
{
    [Route("v2/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IValueValidator _valueValidator { get; }

        public ValuesController(IValueValidator valueValidator)
        {
            _valueValidator = valueValidator;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // check if value is positive
        [HttpGet("isPositive/{id}")]
        public ActionResult<bool> IsPositive(int id)
        {
            return _valueValidator.IsPositive(id);
        }
    }
}
