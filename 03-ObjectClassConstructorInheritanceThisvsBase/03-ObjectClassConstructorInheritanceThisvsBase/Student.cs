using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Student:Person 
    {
        public string StudentNumber;
        public string Faculty;
        public double GPA;
        public int Year;
        
        public Student (string ad, string soyad, int yas, string email, string id, string telebeNomre,string fakulte, double ortaBal, int kurs):base(ad,soyad,yas,email,id)
        {
            this.StudentNumber = telebeNomre;
            this.Faculty = fakulte;
            this.GPA = ortaBal;
            this.Year = kurs;
        }
        public string ShowStudentInfo()
        {
            return StudentNumber + " " + Faculty + " " + GPA + " " + Year;
        }
        public double CalculateScholarship()
        {
            if (GPA>=90)
            {
                return 500; 
            }
             else if (GPA>=80)
            {
                return 350 ; 
            }
            else if (GPA>=70)
            {
                return 200; 
            }
            else
            {
                return 0;
            }
            
            
        }
    }
}
