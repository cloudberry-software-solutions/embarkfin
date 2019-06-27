import { Asset } from '../../../models/asset';
import { AssetService } from './../../../services/asset.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-assetgrid',
  templateUrl: './assetgrid.component.html',
  styleUrls: ['./assetgrid.component.scss']
})
export class AssetgridComponent implements OnInit {

  assets : Asset[];
  constructor(private assetService: AssetService) { }

  ngOnInit() {
    var result = this.getassets()
    console.log(result);
  }

  getassets() {
    this.assetService
    .getAssets()
    .subscribe((data:Asset[]) => {
      console.log(data);
      this.assets = data;
    });
  }

}
