using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace embarkfin.api.Models.Assets
{
    public class QrCode
    {
        public String qrcode { get; set; }

        public QrCode() { }
        public QrCode(String qrcode)
        {
            this.qrcode = qrcode;
        }
    }
}
