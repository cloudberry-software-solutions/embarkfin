#region Using
using Microsoft.EntityFrameworkCore;
using embarkfin.api.Models.Assets;
using embarkfin.api.Models.Login;
#endregion

namespace embarkfin.api.Models.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<AssetEntity> Assets { get; set; }
        public DbSet<DisposalEntity> Disposals {get; set;}

        public DbSet<LocationEntity> Locations {get; set;}
        public DbSet<LoginEntity> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
