using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Teacher :Person
    {
        public string Department;
        public string MainSubject;
        public decimal BaseSalary;
        public int ExperienceYears;
          

        public Teacher(string ad, string soyad, int yas, string email, string id, string kafedra, string esasFenn, decimal bazaMaas, int tecrubeIL) : base(ad, soyad, yas, email, id)
        {
            this.Department =  kafedra ;
            this.MainSubject = esasFenn  ;
            this. BaseSalary = bazaMaas  ;
            this. ExperienceYears= tecrubeIL ;

        }
        public string ShowTeacherInfo()
        {
            return Department + " " + MainSubject + " " +  BaseSalary + " " + ExperienceYears;
        }
        public decimal CalculateSalary()
        {
            return BaseSalary + (ExperienceYears * 50);
        }
    }
    
}
