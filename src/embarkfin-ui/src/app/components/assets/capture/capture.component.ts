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

  constructor(private assetService: AssetServiceService) { }

  ngOnInit() {
  }

  async submitAsset() {
    console.log(this.serialNumber);

    const asset = new AssetModel();
    asset.serialNumber = this.serialNumber;

    const x = await this.assetService.submit(asset).toPromise();
  }

}
