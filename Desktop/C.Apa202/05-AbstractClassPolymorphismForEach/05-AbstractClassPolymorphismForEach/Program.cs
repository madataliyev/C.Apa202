using _05_AbstractClassPolymorphismForEach.Model;
using System.Threading.Channels;

namespace _05_AbstractClassPolymorphismForEach
{
    internal class Proqram
    {
        static void Main()
        {
            Car c1 = new Car("Mercedes", "E200", 2023,4,500,true,220);
            Car c2 = new Car("BMW", "320i", 2022,4,480,true,235);
            Car c3 = new Car("Toyota", "Camry", 2021,4,524,true,210);


            Motorcycle m1 = new Motorcycle("Yamaha", "R1", 2023, 98, false, "sport", 299);
            Motorcycle m2 = new Motorcycle("Harley", "Davidson", 2022, 1868, true, "cruiser", 180);


            Truck t1 = new Truck("Man", "TGX", 2020, 18, 3, 12, 120);
           
            Truck t2 = new Truck("Volvo", "FH16", 2021, 25, 4, 18, 110);

            Vehicle[] vehicles = {c1,c2,c3,m1,m2,t1,t2};


            Console.WriteLine("-----Avtomobiller----");
           c1.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci: {c1.CalculateFuelCost(500)}");
           c2.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci: {c2.CalculateFuelCost(500)}");
           c3.ShowCarInfo();
            Console.WriteLine($"Yanacaq xerci: {c3.CalculateFuelCost(500)}");


            Console.WriteLine("-----Motosikletler----");
           m1.ShowMotorInfo();
            Console.WriteLine($"Yanacaq xerci: {m1.CalculateFuelCost(300)}");
           m2.ShowMotorInfo();
            Console.WriteLine($"Yanacaq xerci: {m2.CalculateFuelCost(300)}");


            Console.WriteLine("-----Yuk masinlari ----");
            t1.ShowTruckInfo();
            Console.WriteLine($"Yanacaq xerci: {t1.CalculateFuelCost(800)}");
            t2.ShowTruckInfo();
            Console.WriteLine($"Yanacaq xerci: {t2.CalculateFuelCost(800)}");


            Console.WriteLine("Uptade truck");
            t1.CurrentLoad = 5;
            Console.WriteLine("yeni truck yanacaq xerci:"+t1.CalculateFuelCost(800));

            int sum = vehicles.Length;
            Console.WriteLine($"Umumi neqliyyat sayi:{sum}");

    }
        
        
    }
        
}
    

