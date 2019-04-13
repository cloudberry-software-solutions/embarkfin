using System;
using Microsoft.EntityFrameworkCore;

namespace embarkfin.api.Domain.Assets
{
    public class AssetContext : DbContext
    {
        public AssetContext(DbContextOptions<AssetContext> options) :base(options)
        {
        }

        public DbSet<AssetEntity> Asset { get; set; }
    }
}
