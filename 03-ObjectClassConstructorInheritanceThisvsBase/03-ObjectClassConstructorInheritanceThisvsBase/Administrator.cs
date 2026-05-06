using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Administrator : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;


        public Administrator(string ad, string soyad, int yas, string email, string id, string vezife, string kafedra, int girisSeviyye) : base(ad, soyad, yas, email, id)
        {
            this.Position = vezife;
            this.Department = kafedra;
            this.AccessLevel = girisSeviyye;
        }
        public string ShowAdminInfo()
        {
            return Position + "" + Department + "" + AccessLevel;
        }
        public void GrantAccess(Student student)
        {
            Console.WriteLine($"{student.GetFullName()} adli telebe sisteme giris etdi");
        }
    }
}

