using _07_NullableEnumStruct.Enums;
using System;
namespace _07_NullableEnumStruct
{
    class Proqram
    {
        static void Main(string[] args)
        { 
            Order order1 = new Order(101,"Ali",DrinkType.Coffee,DrinkSize.Medium);
            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);


            Order order2 = new Order(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);
            order2.DisplayOrder();

            Order order3 = new Order(103, "Vüqar", DrinkType.Juice, DrinkSize.Small);
            order3.DisplayOrder();




            Console.WriteLine("İçki Növləri:");
            foreach (var drink in Enum.GetValues(typeof(DrinkType)))
                Console.WriteLine(" " + drink);

            Console.WriteLine("Ölçülər:");
            foreach (var size in Enum.GetValues(typeof(DrinkSize)))
                Console.WriteLine(" " + size);

            Console.WriteLine("Statuslar:");
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
                Console.WriteLine(" " + status);


            decimal totalAmount = order1.Price + order2.Price + order3.Price;

            Console.WriteLine("--- Statistika ---");
            Console.WriteLine($"Ümumi sifariş sayı: 3");
            Console.WriteLine($"Sifariş 1 Qiymət: {order1.Price} AZN");
            Console.WriteLine($"Sifariş 2 Qiymət: {order2.Price} AZN");
            Console.WriteLine($"Sifariş 3 Qiymət: {order3.Price} AZN");
            Console.WriteLine($"Cəmi Məbləğ: {totalAmount} AZN");

            
        }
    }
           
}


 
