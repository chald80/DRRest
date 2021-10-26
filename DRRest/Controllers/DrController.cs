using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DRClasssLib;
using DRRest.Managers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrController : ControllerBase
    {
        private readonly DrManager _manager = new DrManager();
        // GET: api/<DrController>
        [HttpGet]
        public IEnumerable<DRClass> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<DrController>/5
        [HttpGet("{id}")]
        public DRClass GetById(int id)
        {
            return _manager.GetById(id);
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
