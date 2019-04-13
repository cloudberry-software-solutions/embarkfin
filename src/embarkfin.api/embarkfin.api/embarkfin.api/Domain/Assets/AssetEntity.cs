using System;
namespace embarkfin.api.Domain.Assets
{
    public class AssetEntity
    {
        public long id { get; set; }
        public String serialNumber { get; set; }
        public DateTime datePurchased { get; set; }
        public DateTime dateDisposed { get; set; }
        public long estimatedLifeSpan { get; set; }
        public byte[] QRCode { get; set; }
        public long disposalId { get; set; }
        public long LocationId { get; set; }
        public long Asset_Type_Id { get; set; }



        public AssetEntity()
        {
        }
    }
}
