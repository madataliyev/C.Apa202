using _06_InterfaceAbstraction.Interface;
using _06_InterfaceAbstraction.Models;
using System;
using System.Threading.Channels;
class Proqram:ICalculation
{
    public static void Main(string[] args)
    {
        Calculation calculator = new Calculation();

        Console.WriteLine("----Calculator a Xos Gelmisiniz !!!----");

        Console.WriteLine("Birinci ededi daxil edin: ");
        double x=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Emeliyyati secin (+,-,*,/): ");
        char symbol= Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Ikinci ededi daxil edin: ");
        double y=Convert.ToDouble(Console.ReadLine());

        double finished=calculator.Calculate(x,y,symbol);
        Console.WriteLine("Cavab: "+ finished);
       
    }

    public void Calculate() { }
   
}