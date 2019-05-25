﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using embarkfin.api.Models.Assets;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace embarkfin.api.Controllers
{
    [Route("embarkfin/v1/assets")]
    public class AssetsController : Controller
    {
        private DatabaseContext context;
        private AssetRepository assetRepository;

        public AssetsController(DatabaseContext context)
        {
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
        public string Get(String Serial_Number)
        {
            return assetRepository.GetByRefNumber(Serial_Number).ToString();
        }

        // POST api/values
        [HttpPost()]
        [Route("/embarkfin/v1/assets/create")]
        public String Post([FromBody]String test)
        {

            //refactor when service is created, factory method should not be called in the controller.
            assetRepository.Insert(AssetFactory.createAssetFromJson(test));

            return test;
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
