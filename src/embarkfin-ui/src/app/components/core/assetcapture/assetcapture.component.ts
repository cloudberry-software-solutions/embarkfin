import { Asset } from '../../../models/asset';
import { AssetService } from './../../../services/asset.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-assetcapture',
  templateUrl: './assetcapture.component.html',
  styleUrls: ['./assetcapture.component.scss']
})
export class AssetcaptureComponent implements OnInit {

  serialNumber: string;
  dateOfPurchase: Date;
  period: number;
  purchasePrice: number;

  qrCode : any;


  constructor( private assetService: AssetService, private router: Router) { }

  ngOnInit() {
  }

  async submit() {
    const asset  = new Asset( this.serialNumber, this.dateOfPurchase, this.period, this.purchasePrice);
    const result = await this.assetService.saveAsset(asset).toPromise();
    console.log(result);
    this.router.navigateByUrl('assetqrcode/' + this.serialNumber);
    console.log("Redirected client to qr code screen");

  }

}
