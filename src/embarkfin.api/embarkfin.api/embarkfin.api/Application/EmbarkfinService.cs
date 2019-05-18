using System;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace embarkfin.api.Application
{
    public class EmbarkfinService
    {
        private AssetRepository assetRepository = new AssetRepository(new DbContextOptions<DatabaseContext>);

        public EmbarkfinService()
        {
        }
    }
}
