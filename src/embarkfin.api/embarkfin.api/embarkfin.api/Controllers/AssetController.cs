using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using embarkfin.api.Domain.Assets;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace embarkfin.api.Controllers
{
    [Route("embarkfin-service/v1/Assets")]
    public class AssetController : ControllerBase
    {
        private readonly AssetContext assetContext;

        public AssetController(AssetContext context)
        {
            assetContext = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            assetContext.Asset.Add(new AssetEntity { serialNumber = "testing" });
            assetContext.SaveChanges();
            return "succesfully generated Asset";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
