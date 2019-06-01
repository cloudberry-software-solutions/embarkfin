using System;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using Microsoft.EntityFrameworkCore;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Datamatrix;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
namespace embarkfin.api.Application
{
    public class EmbarkfinService
    {        
        private AssetRepository assetRepository;

        public EmbarkfinService(AssetRepository assetRepository)
        {
            this.assetRepository = assetRepository;
        }

        public String createBarcode(String embeddedValue)
        {
            QRCodeWriter writer = new QRCodeWriter();    
            QRCodeReader reader = new QRCodeReader();        

            BitMatrix code = writer.encode(embeddedValue,BarcodeFormat.QR_CODE,100,100);


            return code.ToString() ;
        }
    }
}
