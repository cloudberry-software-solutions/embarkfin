import { Component, OnInit } from '@angular/core';
import { AssetService } from 'src/app/services/asset.service';
import { ActivatedRoute } from '@angular/router';
import { stringify } from '@angular/compiler/src/util';
import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-assetqrcode',
  templateUrl: './assetqrcode.component.html',
  styleUrls: ['./assetqrcode.component.scss']
})
export class AssetqrcodeComponent implements OnInit {

  qrCode : any;
  imageScript : any

  constructor(private assetService: AssetService, private route: ActivatedRoute, private sanitizer: DomSanitizer) { }

  ngOnInit() {
    this.getQrCodeFromService(this.route.snapshot.paramMap.get("embeddedvalue"))
    this.sanitizer.bypassSecurityTrustHtml("data:image/png;base64,"+this.qrCode);
  }

  getQrCodeFromService(embeddedValue: string) {
  this.qrCode =  this.assetService.getQRCode(embeddedValue);
  this.sanitizer.bypassSecurityTrustUrl("http://localhost:4200/assetqrcode/:embeddedvalue");
  console.log(this.qrCode);
  console.log(this.imageScript);


  }

}
