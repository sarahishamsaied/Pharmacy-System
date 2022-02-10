using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    public class Receipt
    {
        string Id { get; set; }
        string Name { get; set; }
        string ProductCode { get; set; }
        double Price { get; set; }
        string dateOfPurchase { get; set; }
        string ProductName { get; set; }

        public Receipt()
        {
            Id = Name = ProductCode = dateOfPurchase = "";
            Price = 0;
        }
        public Receipt(string name,string code,string dateOfPurchase,string id,string productName,double price)
        {
            this.Name = name;
            this.ProductCode = code;
            this.dateOfPurchase = dateOfPurchase;
            this.Id = id;
            this.ProductName = productName;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"************** Pharmacy System *******************\n\n\nBuyer Name: {this.Name}\n\n\nProduct Name: {ProductName}\n\n\nProduct Price: {Price}$\n\n\nDate of Purchase: {this.dateOfPurchase}\n\n\n******************** Thank You! ********************";
        }
    }
}
