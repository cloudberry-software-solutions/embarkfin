using System;
using embarkfin.api.Models.Database;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
namespace embarkfin.api.Models.Assets
{
    public static class AssetFactory
    {
        public static AssetEntity createAssetFromJson(String assetJson)
        {
            JObject jsonObject = JObject.Parse(assetJson);
            String serialNumber = jsonObject.GetValue("serialNumber").ToString();
            DateTime date_purchased = DateTime.Parse(jsonObject.GetValue("Date_Purchased").ToString());
            long period = long.Parse (jsonObject.GetValue("Period").ToString());
            double purchase_price = Double.Parse(jsonObject.GetValue("Purchase_Price").ToString());

            AssetEntity asset = new AssetEntity(serialNumber, date_purchased, period, purchase_price);

            return asset;
        }
    }
}
