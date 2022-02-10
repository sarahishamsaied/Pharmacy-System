using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{

    class Cashier : Staff
    {
        public Cashier() : base()
        {
            
        }
        public Cashier(string name, int age, string id, string address, string phoneNumber, string gender, double workingHours, double salary, double bonus, string shift) : base(name, age, id, address, phoneNumber, gender, workingHours, salary, bonus)
        {
            this.shift = shift;
        }

        string shift;
      public string Shift { get { return shift; } set { shift = value; } }

    }
}

