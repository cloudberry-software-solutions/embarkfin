using System.ComponentModel.DataAnnotations.Schema;
using embarkfin.api.Models.Database;
using System;

namespace embarkfin.api.Models.Assets
{
    [Table("Asset")]
    public class AssetEntity : BaseEntity
    {
        [Column("Serial_Number")]
        public String Serial_Number { get; set; }

        [Column("Date_Purchased")]
        public DateTime Date_Purchased { get; set; }

        [Column("Period")]
        public long Period { get; set; }

        [Column("Purchase_Price")]
        public double Purchase_Price { get; set; }

    }
}
