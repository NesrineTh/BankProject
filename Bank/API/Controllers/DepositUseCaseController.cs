using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.UseCases.Deposit;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/deposit")]
    [ApiController]
    public class DepositUseCaseController : ControllerBase
    {
        private readonly IDepositUseCaseService _depositUseCaseService;
        public DepositUseCaseController(IDepositUseCaseService depositUseCaseService)
        {
            _depositUseCaseService = depositUseCaseService;
        }
        // GET: api/<DepositUseCaseController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DepositUseCaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DepositUseCaseController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepositUseCaseController>/5
        [HttpPut("{id}")]
        public void Put(long bankNumber, [FromBody] string amount)
        {

        }

        // DELETE api/<DepositUseCaseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
