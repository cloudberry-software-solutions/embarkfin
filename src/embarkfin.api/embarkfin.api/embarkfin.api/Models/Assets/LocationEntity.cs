using System.ComponentModel.DataAnnotations.Schema;
using embarkfin.api.Models.Database;
using System;
namespace embarkfin.api.Models.Assets
{
    [Table("Location")]
    public class LocationEntity
    {
        [Column("LocationId")]
        public int LocationEntityId { get; set; }

        [Column("Longitude")]
        public long Longitude { get; set; }

        [Column("Latitude")]
        public long Latitude { get; set; }

        [Column("Date_Captured")]
        public DateTime DateCaptured { get; set; }
    }
}
