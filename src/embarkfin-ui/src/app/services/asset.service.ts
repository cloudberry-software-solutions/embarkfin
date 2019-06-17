import { AssetModel } from './../models/assetModel';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AssetService {

  constructor(private http: HttpClient) { }

  calcUrl = 'https://localhost:44381/embarkfin/v1/assets/create';

  saveAsset(asset: AssetModel) {
    return this.http.post(this.calcUrl, asset);
  }
}

