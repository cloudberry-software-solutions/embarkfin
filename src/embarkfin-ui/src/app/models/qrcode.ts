export class QrCode {
  qrcode: string;

  constructor(qrcode: string){
    this.qrcode = qrcode;
  }

  public setqrcode(barcode: string){
    this.qrcode = barcode;
  }

  public getqrcode()
  {
    return this.qrcode;
  }

}