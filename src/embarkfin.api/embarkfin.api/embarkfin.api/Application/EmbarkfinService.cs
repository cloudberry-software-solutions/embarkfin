using System;
using embarkfin.api.Models.Database;
using embarkfin.api.Repositories;
using Microsoft.EntityFrameworkCore;
//using System.Drawing;
//using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;
using QRCoder;

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
                String code = embeddedValue;
                QRCodeGenerator gen = new QRCodeGenerator();
                QRCodeData QRCODE = gen.CreateQrCode(embeddedValue, QRCodeGenerator.ECCLevel.L);
                Base64QRCode theCode = new Base64QRCode(QRCODE);

                return theCode.GetGraphic(20);

        }
    }
}
