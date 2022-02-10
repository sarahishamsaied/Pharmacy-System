using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Customer:Person
    {
        public Customer(string name, int age, string id, string address, string phoneNumber, string gender) :base(name,age,id,address,phoneNumber,gender)
        {
        }

        Product BoughtProduct { get; set; }
        List<Product> AllBoughtProducts = new List<Product> { };
        public override string ToString()
        {
            var combined = string.Join(", ", AllBoughtProducts);
            return base.ToString()+$"\n{combined}";
        }
        public string printBill()
        {
            return $"Name: {this.Name}\nPhone Number: {this.PhoneNumber}\nAddress:{this.Address}\n";
        }
    }
}
