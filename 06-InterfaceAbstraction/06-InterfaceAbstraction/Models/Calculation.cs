using _06_InterfaceAbstraction.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction.Models
{
    public  class Calculation :ICalculation
    {
        public double Calculate(double x, double y, char symbol)
        {
            double result = 0;

            switch(symbol)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y!=0)
                    {
                        result = x / y;
                       
                    }
                    else
                    {
                        Console.WriteLine("Sifira bolmek olmaz");
                    }
                    break;
                default:
                    Console.WriteLine("Emeliyyat yanlisdir,zehmet olmasa duzeldin!");
                    break;
            }
            return result;
        }

        public void Calculate() { }
       
    }
}
