using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cricket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        // GET: api/Matches
        private readonly CricketContext _matches;
        public MatchesController(CricketContext matches)
        {
            _matches = matches;
        }
        [HttpGet]
        public IActionResult Get2()
        
            {
                var getCountry = _matches.Matches.ToList();
                return Ok(getCountry);
            }
        
        /*public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET: api/Country/5
            [HttpGet("{id}", Name = "Get")]
            public string Get(int id)
            {
                return "value";
            }

            // POST: api/Country
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // PUT: api/Country/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE: api/ApiWithActions/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }*/
    }
}