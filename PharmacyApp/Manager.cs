using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Manager : Staff
    {
        public Manager() : base()

        {

        }
        public Manager(string name, int age, string id, string phoneNumber, string address, string shift, string gender, double bonus, double workingHours,double salary,DateTime dateOfHire) : base(name, age, id,address,phoneNumber, gender, workingHours,salary, bonus)
        {
            this.shift = shift;
            this.dateOfHire = DateTime.Now;
            this.salary = salary; 
   
        }
        string shift;
        public string Shift { get; set; }
        DateTime dateOfHire { get; set; }
        double salary;
        public void fire()
        {

        }
        public void hire()
        {

        }
    }
}
    
