﻿using System.ComponentModel.DataAnnotations.Schema;
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

        [Column("LocationId")]
        public int LocationId { get; set; }

        [Column("DisposalId")]
        public int DisposalId { get; set; }

        [ForeignKey("LocationId")]
        public DisposalEntity disposal { get; set; }

        [ForeignKey("DisposalId")]
        public LocationEntity location { get; set; }

    }
}
