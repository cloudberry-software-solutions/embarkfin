using System;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using Microsoft.EntityFrameworkCore;

namespace embarkfin.api.Application
{
    public class EmbarkfinService
    {        
        private AssetRepository assetRepository;

        public EmbarkfinService(AssetRepository assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        public byte[] createBarcode(String embeddedValue)
        {
            return new byte[]{};
        }
    }
}
