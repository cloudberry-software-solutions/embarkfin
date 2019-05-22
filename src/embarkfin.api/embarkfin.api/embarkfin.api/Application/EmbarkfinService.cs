using System;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace embarkfin.api.Application
{
    public class EmbarkfinService
    {
        private DatabaseContext Context;
        
        private AssetRepository assetRepository;

        public EmbarkfinService(DatabaseContext context)
        {
        }
    }
}
