using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using embarkfin.api.Models.Assets;
using embarkfin.api.Models.Database;

namespace embarkfin.api.Repositories
{
    public class AssetRepository : MasterRepository<AssetEntity>
    {
        AssetRepository(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        

    }
}
