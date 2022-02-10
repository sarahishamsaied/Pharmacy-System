using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    abstract class Person
    {
        public Person()
        {
            this.name = String.Empty;
            this.age = 0;
            this.id = String.Empty;
            this.address = String.Empty;
            this.phoneNumber = String.Empty;
            this.gender = String.Empty;
        }
        public Person(string name, int age, string id,string address,string phoneNumber,string gender)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
        }
        string name;
        string id;
        int age;
        string address;
        string gender;
        string phoneNumber;
        public string Name { get { return name; } set { name = value; } }
        public string Id { get { return id; } set { id = value; } }
        public int Age { get { return age; } set { age = (value >= 0) ? value : 0; } }
        public string Address { get { return address; } set { address = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public override string ToString()
        {
            return $"Name:{this.name}\nAge:{this.age}\nAddress:{this.address}\nPhoneNumber{this.phoneNumber}\nGender:{this.gender}";
        }

    }
}
