using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace embarkfin.api.Controllers
{
    [Route("api/[controller]/login")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // GET: api/Auth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value4", "value2dsadf" };
        }

        // GET: api/Auth
        [HttpGet]
        [Route("api/[controller]/login")]
        public IEnumerable<string> Login()
        {
            return new string[] { "We git the login method " };
        }

        // GET: api/Auth/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Auth
        [HttpPost]
        public void Post([FromBody] string value)
        {
          //  return new Object { "Token: gfhdfhfdfghjffghdg" };
        }

        // PUT: api/Auth/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
