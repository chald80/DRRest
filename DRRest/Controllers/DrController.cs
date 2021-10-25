using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrController : ControllerBase
    {
        // GET: api/<DrController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DrController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DrController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DrController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DrController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
