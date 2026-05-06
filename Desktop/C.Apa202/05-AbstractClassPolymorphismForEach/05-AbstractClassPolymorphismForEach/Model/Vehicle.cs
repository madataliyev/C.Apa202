using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Model
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;
        public string PlateNumber;
        public double FuelLevel;


        public Vehicle(string marka, string model, int il )
        {
            this.Brand = marka;
            this.Model = model;
            this.Year = il;
          
        }
        public string GetVehicleInfo()
        {
            return Brand + " " + Model + " " + Year + " " + PlateNumber + " " + FuelLevel;
        }
        public void ShowBasicInfo()
        {
            Console.WriteLine($"markasi:{Brand}, modeli:{Model}, ili:{Year}, qeydiyyat nomresi:{PlateNumber}, yanacaq seviyyesi;{FuelLevel}");
        }
    }
}
