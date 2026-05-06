using System;
using System.Collections.Generic;
using System.Text;

namespace _05_AbstractClassPolymorphismForEach.Model
{
    internal class Car :Vehicle
    {
        public int DoorsCount;
        public int TrunkCapacity;
        public bool IsAutomatic;
        public int MaxSpeed;


        public Car(string marka, string model, int il,  int QSayi, int BTutumu, bool ASQutusu,int MSuret): base (marka,model, il)
        {
            this.DoorsCount = QSayi;
            this.TrunkCapacity = BTutumu;
            this.IsAutomatic = ASQutusu;
            this.MaxSpeed = MSuret;

        }
        public string ShowCarInfo()
        {
            return DoorsCount + " " + TrunkCapacity + " " + IsAutomatic + " " + MaxSpeed;

        }
        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }


    }
}
