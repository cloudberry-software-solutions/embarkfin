using System.ComponentModel.DataAnnotations.Schema;
using embarkfin.api.Models.Database;
using System;

namespace embarkfin.api.Models.Assets
{
    [Serializable]
    [Table("Asset")]
    public class AssetEntity : BaseEntity
    {
        [Column("Serial_Number")]
        public String Serial_Number { get; set; } 

        [Column("Date_Purchased")]
        public System.Nullable<DateTime> Date_Purchased { get; set; }

        [Column("Period")]
        
        public System.Nullable<long> Period { get; set; }

        [Column("Purchase_Price")]
        public System.Nullable<double> Purchase_Price { get; set; }

        [Column("DisposalId")]
        public System.Nullable<int> DisposalId{get; set;}

        [Column("LocationId")]
        public System.Nullable<int> LocationId{get;set;}


        [ForeignKey("DisposalId")]
        public DisposalEntity Disposal { get; set; }

        [ForeignKey("LocationId")]
        public LocationEntity Location { get; set; }

        public AssetEntity(String Serial_Number, System.Nullable<DateTime> Date_Purchased, System.Nullable<long> Period, System.Nullable<double> Purchase_Price)
        {
            this.Serial_Number = Serial_Number;
            this.Date_Purchased = Date_Purchased;
            this.Period = Period;
            this.Purchase_Price = Purchase_Price;

        }

    }
}
