using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
     class Dashboard
    {
        static public double TotalBalance { get; set; }
        public static List<Customer> AllCustomers = new List<Customer> { };
        public static List <Staff> allStaffMembers = new List<Staff> { };
        public static List<Product> AllProducts = new List<Product> { };
    }
}
