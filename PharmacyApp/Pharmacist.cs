using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Pharmacist: Staff {
        public Pharmacist() : base()
        {
            this.shift = String.Empty;
            this.speciality = String.Empty;
        }
        public Pharmacist(string name, int age, string id, string address, string phoneNumber, string gender, double workingHours, double salary, double bonus, string shift, string speciality) : base(name, age, id, address, phoneNumber, gender, workingHours, salary, bonus)
        {
            this.shift = shift;
            this.speciality = speciality; 
        }

        string shift;
        string speciality;
        public string Shift { get { return shift; } set { shift = value; } }
        public string Specilaity { get { return speciality; } set { speciality = value; } }
    }
    }

