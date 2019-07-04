import { Component, OnInit, EmbeddedViewRef } from '@angular/core';
import { AssetService } from 'src/app/services/asset.service';
import { ActivatedRoute } from '@angular/router';
import { DomSanitizer } from '@angular/platform-browser';
import { QrCode } from 'src/app/models/qrcode';

@Component({
  selector: 'app-assetqrcode',
  templateUrl: './assetqrcode.component.html',
  styleUrls: ['./assetqrcode.component.scss']
})
export class AssetqrcodeComponent implements OnInit {

  qrCode : QrCode;
  src : any = " ";
  tester : number = 0;

  constructor(private assetService: AssetService, private route: ActivatedRoute, private sanitizer: DomSanitizer) { }

  ngOnInit() {
    this.getQrCodeFromService(this.route.snapshot.paramMap.get("embeddedvalue"))
    if(this.qrCode != undefined){
      this.src = this.sanitizer.bypassSecurityTrustUrl('data:image/jpeg;charset=binary;base64,' + this.qrCode.getqrcode());
    }
    console.log(this.qrCode);
  }

   getQrCodeFromService(embeddedValue: string) {
    console.log(this.tester)
    this.tester++ 
   this.assetService
  .getQRCode(embeddedValue)
  .subscribe((data:QrCode) => {
    console.log(data);
    this.qrCode = new QrCode(data);
    this.src = this.sanitizer.bypassSecurityTrustUrl('data:image/jpeg;charset=binary;base64,' + this.qrCode.getqrcode());

  }) ;
  }

}
