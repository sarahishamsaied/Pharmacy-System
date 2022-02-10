using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    public class Product
    {

        string productName;
        string productCode;
        string expiryDate;
        double price;
        double quantity;
        string type;
        string supplier;
        double discount;
        public Product(string productName,string productCode,double price,string type,string supplier,double discount,double quantity ,string expiryDate)
        {
            this.productName = productName;
            this.productCode = productCode;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
            this.supplier = supplier;
            this.discount = discount;
            this.expiryDate = expiryDate.ToString();
        }
        public string ProductName { get { return productName; } set { productName = value; } }
        public string ProductCode { get { return productCode; } set { productCode = value; } }
        public double Price { get { return price; } set { price = value >= 0 ? value : 0; } }
        public double Quantity { get { return quantity; } set { quantity = value >= 0 ? value : 0; } }
        public string Type { get { return type; } set { type = value; } }
        public string Supplier { get { return supplier; } set { supplier = value; } }

        public double Discount { get { return discount; } set { discount = value >= 0 ? value : 0; } }

        public string ExpiryDate { get { return expiryDate; } set { expiryDate = value; } }

        public override string ToString()
        {
            return string.Format($"product Name: {this.productName}\nproduct Type: {this.type}\nproduct Code: {this.productCode}\nSupplier: {this.supplier}\nPrice:{this.price}:C");
        }

    }
}
