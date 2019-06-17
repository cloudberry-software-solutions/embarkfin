export class AssetModel {
    // tslint:disable-next-line:variable-name
    Serial_Number: string;
    // tslint:disable-next-line:variable-name
    Date_Purchased: Date;
    Period: number;
    // tslint:disable-next-line:variable-name
    Purchase_Price: number;

    constructor( serialNumber: string, dateOfPurchase: Date, period: number, purchasePrice: number) {
        this.Serial_Number = serialNumber;
        this.Date_Purchased = dateOfPurchase;
        this.Period = period;
        this.Purchase_Price = purchasePrice;
    }

}
