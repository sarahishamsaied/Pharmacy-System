using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Sell
    {
        string buyerName;
        DateTime dateOfPurchase;
        public string BuyerName { get; set; }
        Product boughtProduct;
        public Product BoughtProduct { get; set; }
        public Sell(string buyerName,string boughtProductCode)
        {
            this.buyerName = buyerName;
            this.dateOfPurchase = DateTime.Now;
            Product originalProduct = getProductData(boughtProductCode);
            if(originalProduct == null)
                return;
            this.boughtProduct = originalProduct;
            if (this.boughtProduct.Quantity == 0)
                return; 
        }
        public Product getProductData(string code)
        {
            return Dashboard.AllProducts.Find(val => code == val.ProductCode);
        }


    }
}
