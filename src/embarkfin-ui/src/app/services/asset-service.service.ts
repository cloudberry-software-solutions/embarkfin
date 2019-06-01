import { AssetModel } from './../models/assetModel';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AssetServiceService {

  constructor(private http: HttpClient) { }

  calcUrl = 'https://localhost:44381/embarkfin/v1/assets/create';

  submit(asset: AssetModel) {
    // return this.http.post(this.calcUrl, '{serialNumber: ''testingGP'',Date_Purchased: ''2015-05-16T05:50:06 '',Period: ''5'',Purchase_Price: ''123000,12''}'');

    return this.http.post(this.calcUrl, asset);
  }
}
