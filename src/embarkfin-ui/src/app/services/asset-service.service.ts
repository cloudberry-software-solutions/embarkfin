import { AssetModel } from './../models/assetModel';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AssetServiceService {

  constructor(private http: HttpClient) { }
// amend port according to your local machine
  calcUrl = 'https://localhost:5001/embarkfin/v1/assets';

  submit(asset: AssetModel) {
    // return this.http.post(this.calcUrl, '{serialNumber: ''testingGP'',Date_Purchased: ''2015-05-16T05:50:06 '',Period: ''5'',Purchase_Price: ''123000,12''}'');

    //asset.Serial_Number = 'this test works';

    return this.http.post(this.calcUrl + '/create', asset);
  }

  getAllAssets(){

    return this.http.get(this.calcUrl + '/getAll').forEach((Response) => console.log(Response));
    
  }

}
