using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
        public string Id;
     
    public Person(string ad, string soyad, int yas, string email, string id)
        {
            this.FirstName = ad;
            this.LastName = soyad;
            this.Age = yas;
            this.Email = email;
            this.Id = id;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public  void ShowBasicInfo()
        {
            Console.WriteLine($" ad-soyad; {GetFullName}, yas; {Age}, email; {Email}, sexsi id; {Id}");
        }




    }
}
