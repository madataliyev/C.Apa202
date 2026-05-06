using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Model
{
    internal class Motorcycle:Vehicle
    {
        public int EngineCapacity;
        public bool Hassidecar;
        public int MaxSpeed;
        public string Type;


        public Motorcycle(string marka, string model, int il,  int MHecmi, bool EOturacaq, string  nov, int MSuret) : base(marka, model, il)
        {
            this.EngineCapacity = MHecmi;
            this.Hassidecar = EOturacaq;
            this.MaxSpeed = MSuret;
            this.Type = nov;

        }
        public string ShowMotorInfo()
        {
            return EngineCapacity + " " + Hassidecar + " " + MaxSpeed + " " + Type;

        }
        public  double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }

    }
}
