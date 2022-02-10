using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
   abstract class Staff: Person {
        public Staff() : base()
        {
            this.salary = 0;
            this.dateOfHire = DateTime.Today; 
            this.bonus = 0;
            this.workingHours = 0;

        }
        public Staff( string name, int age, string id, string address, string phoneNumber, string gender, double workingHours, double salary,double bonus): base( name,age, id, address, phoneNumber, gender)
        {
            this.bonus = bonus;
            this.workingHours = workingHours;
            this.salary = salary;
            this.dateOfHire = DateTime.Today;
        }
        double salary;
        DateTime dateOfHire;
        double bonus;
        double workingHours;
        public double Salary { get { return salary; } set { salary = (value >= 0) ? value : 0; } }
        public DateTime DateOfHire { get { return dateOfHire; } set { dateOfHire = value; } }
        public double Bonus { get { return bonus; } set { bonus= (value >= 0) ? value : 0; } }
        public double WorkingHours { get { return workingHours; } set { workingHours = (value >= 0) ? value : 0; } }
    } 

    
}
