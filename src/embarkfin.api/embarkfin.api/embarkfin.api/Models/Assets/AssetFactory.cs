using System;
using Newtonsoft.Json.Linq;
namespace embarkfin.api.Models.Assets
{
    public static class AssetFactory
    {
       public static void createAssetFromJson(String assetJson)
        {
            JObject jsonObject = JObject.Parse(assetJson);

            String serialNumber = (String)jsonObject.GetValue("serialNumber");
        }
    }
}
