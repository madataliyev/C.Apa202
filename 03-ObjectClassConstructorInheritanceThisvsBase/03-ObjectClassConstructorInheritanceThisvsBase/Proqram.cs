using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase
{
    internal class Proqram
    {
       static void Main()
        {
            Student s1 = new Student("Eli", "Haciyev", 18, "elihaciyev8@gmail.com", "eh2008", "st-111", "It fakulte", 88.5, 1);
            Student s2 = new Student("Veli", "Veliyev", 19, "veliveliyev7@gmail.com", "vv2007", "st-222", "Masin qayirma", 92.0, 2);
            Student s3 = new Student("Akif","Agayev", 20,"akifagayev5@gmail.com","aa-2006","st-333","Mexatronika",68.5,3);

            Teacher t2 = new Teacher("Aliye", "Memmedova", 38, "aliyememmedova88@gmail.com", "tt-1988", "Mexatronika", "tetbiqi riyaziyyat", 1000, 8);
            Teacher t1 = new Teacher("Qurban", "Qurbanov", 46, "qurbanqurbanov80@gmail.com", "tt-1980", "It ", "Komputer elmleri", 1800, 15);


            Administrator admin = new Administrator("Qara", "Eliyev", 60, "qaraeliyev66@gmail.com", "aa-777", "dekan", "Energetika", 5);


            Console.WriteLine("-----Telebeler----");
            s1.ShowStudentInfo();
            Console.WriteLine($"teqaut: {s1.CalculateScholarship()}");
            s2.ShowStudentInfo();
            Console.WriteLine($"teqaut: {s2.CalculateScholarship()}");
            s3.ShowStudentInfo();
            Console.WriteLine($" teqaut : {s3.CalculateScholarship()}");


            Console.WriteLine("----Muellimler----");
            t1.ShowTeacherInfo();
            Console.WriteLine($"Maas: {t1.CalculateSalary()}");
            t2.ShowTeacherInfo();
            Console.WriteLine($"Maas: {t2.CalculateSalary()}");

            Console.WriteLine("-----Admin_-----");
            admin.ShowAdminInfo();

            admin.GrantAccess(s1);

            double totalScholarship=s1.CalculateScholarship()+s2.CalculateScholarship()+s3.CalculateScholarship();
            decimal totalSalary=t1.CalculateSalary()+t2.CalculateSalary();


            Console.WriteLine("-------Statistika-------");
            Console.WriteLine($"Umumi teqaud xerci : {totalScholarship}");
            Console.WriteLine($"Umumi maas xerci: {totalSalary}");


        }

    }
}
