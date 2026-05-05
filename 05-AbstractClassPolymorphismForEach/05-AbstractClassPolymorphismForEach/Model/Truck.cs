using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Model
{
    internal class Truck: Vehicle
    {
        public double CargoCapacity;
        public int AxleCount;
        public double CurrentLoad;
        public int MaxSpeed;
    
     public Truck(string marka, string model, int il, double YTutumu, int OSayi, double CYuk, int MSuret) : base(marka, model, il)
        {
            this.CargoCapacity = YTutumu;
            this.AxleCount = OSayi;
            this.CurrentLoad = CYuk;
            this.MaxSpeed = MSuret;
        }
        public string ShowTruckInfo()
        {
            return CargoCapacity + " " + AxleCount + " " + CurrentLoad + " " + MaxSpeed;

        }
        public void LoadCargo()
        {
            if (AxleCount*CurrentLoad<=CargoCapacity)
            {
                Console.WriteLine($" Yukunuz:{AxleCount * CurrentLoad}, Yolunuz aciq olsun!");
            }
            else
            {
                Console.WriteLine($"Yukunuz coxdur,irelleme olmayacaq");
            }

        }
        public  double CalculateFuelCost(double distance)
        {
            double a= (distance / 100) * (25 + CurrentLoad*2)*1.80;
            return a;
        }

    }
}
