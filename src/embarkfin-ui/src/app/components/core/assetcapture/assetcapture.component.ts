import { AssetModel } from './../../../models/assetModel';
import { AssetService } from './../../../services/asset.service';
import { Component, OnInit } from '@angular/core';

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


  constructor( private assetService: AssetService) { }

  ngOnInit() {
  }

  async submit() {
    const asset  = new AssetModel( this.serialNumber, this.dateOfPurchase, this.period, this.purchasePrice);
    const result = await this.assetService.saveAsset(asset).toPromise();
    console.log(result);
  }
}
