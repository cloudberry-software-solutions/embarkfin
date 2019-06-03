using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Newtonsoft.Json.Linq;
using embarkfin.api.Models.Assets;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using embarkfin.api.Application;
using ZXing.Common;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace embarkfin.api.Controllers
{
    [Route("embarkfin/v1/assets")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        private DatabaseContext context;
        private AssetRepository assetRepository;

        private EmbarkfinService embarkfinService;

        public AssetsController(DatabaseContext context, EmbarkfinService embarkfinService)
        {
            this.embarkfinService = embarkfinService;
            assetRepository = new AssetRepository(context);
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{Serial_Number}")]
        public AssetEntity Get(String Serial_Number)
        {
            return assetRepository.GetByRefNumber(Serial_Number);
        }

        [HttpGet]
        [Route("/embarkfin/v1/assets/getAll")]
        public ActionResult<List<AssetEntity>> getAssets()
        {
            return assetRepository.GetAll();
        }

        // POST api/values
        [EnableCors("CorsPolicy")]
        [HttpPost]
        [Route("/embarkfin/v1/assets/create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<AssetEntity> Post(AssetEntity asset)
        {
            //refactor when service is created, factory method should not be called in the controller.
            assetRepository.Insert(asset);

                return CreatedAtAction(nameof(asset.Id),
                        new { id = asset.Id }, asset);
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
            assetRepository.Delete(assetRepository.GetById(id));
        }
    }
}
