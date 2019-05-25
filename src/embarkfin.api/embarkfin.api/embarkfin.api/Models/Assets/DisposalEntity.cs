using System.ComponentModel.DataAnnotations.Schema;
using embarkfin.api.Models.Database;
using System;

namespace embarkfin.api.Models.Assets
{
    [Table("Disposal")]
    public class DisposalEntity : BaseEntity
    {

        [Column("DisposalId")]
        public int DisposalEntityId { get; set; }

        [Column("Disposed_Date")]
        public DateTime DisposedDate { get; set; }

        [Column("Disposal_Price")]
        public double DisposedPrice { get; set; }
    }

}
