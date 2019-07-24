import { Asset } from '../../../models/asset';
import { AssetService } from './../../../services/asset.service';
import { Component, OnInit } from '@angular/core';
import { MatTableModule } from '@angular/material/table';


@Component({
  selector: 'app-assetgrid',
  templateUrl: './assetgrid.component.html',
  styleUrls: ['./assetgrid.component.scss']
})
export class AssetgridComponent implements OnInit {
  displayedColumns : String[ ] = ['Serial_Number', 'Date_Purchased', 'Period', 'Purchase_Price','Update', 'Dispose'];
  assets : any ;
  constructor(private assetService: AssetService) {
    this.assets = assetService.getAssets().subscribe((data:Asset[]) => {
      console.log(data);
      this.assets = data;
    });;
   }

  ngOnInit() {    
  }

  delete(item){
    // your delete code
    console.log(item);
  }

}
