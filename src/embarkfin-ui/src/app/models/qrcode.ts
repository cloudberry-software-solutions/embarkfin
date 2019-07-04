export class QrCode {
  public qrcode: string;

  public constructor(object : Object){
    Object.assign(this, object)
  }

  public setqrcode(barcode: string){
    this.qrcode = barcode;
  }

  public getqrcode() : string
  {
    return this.qrcode;
  }

}