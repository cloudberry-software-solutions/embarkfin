import { AssetModel } from './../../../models/assetModel';
import { AssetServiceService } from './../../../services/asset-service.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-capture',
  templateUrl: './capture.component.html',
  styleUrls: ['./capture.component.scss']
})
export class CaptureComponent implements OnInit {

  serialNumber = '';
  period = 0;
  purchasePrice = 0;

  assets;

  constructor(private assetService: AssetServiceService) { }

  ngOnInit() {
  }

  async submitAsset() {
    console.log(this.serialNumber);

    const asset = new AssetModel();
    asset.Serial_Number = this.serialNumber;
    asset.Period = this.period;
    asset.Purchase_Price = this.purchasePrice;

    const x = this.assetService.submit(asset).toPromise();

    this.assetService.getAllAssets();
  }

}
