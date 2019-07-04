import { Asset } from '../models/asset';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class AssetService {

  constructor(private http: HttpClient) { }

  calcUrl = 'https://localhost:44381/embarkfin/v1/assets/create';
  getassetsurl = 'https://localhost:44381/embarkfin/v1/assets/getall'
  getQrCodeurl = 'https://localhost:44381/embarkfin/v1/assets/getQRCode'

  saveAsset(asset: Asset) {
    return this.http.post(this.calcUrl, asset);
  }

  getAssets(){
    return this.http.get(this.getassetsurl)
  }

 getQRCode(embeddedValue: string ) {
    return this.http.get(this.getQrCodeurl+ '/' + embeddedValue)
  }
}

