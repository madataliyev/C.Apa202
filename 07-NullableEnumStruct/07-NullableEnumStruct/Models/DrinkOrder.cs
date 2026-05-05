using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace _07_NullableEnumStruct.Models
{
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }



        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;

            Status = OrderStatus.New;

            Price = CalculatePrice(drink, size);
        }
        
        public static decimal CalculatePrice(DrinkType drink,DrinkSize size)
        {
            decimal price = 0;
            switch (drink)
            {
                case DrinkType.Coffee:
                    switch (size)
                    {
                        case DrinkSize.Small: price = 3;break;
                        case DrinkSize.Medium: price = 4;break;
                        case DrinkSize.Large: price = 5;break;
                    }
                    break;
                case DrinkType.Tea:
                    switch (size)
                    {
                        case DrinkSize.Small: price = 2;break;
                        case DrinkSize.Medium: price = 3;break;
                        case DrinkSize.Large: price = 4;break;
                    }
                    break;
                case DrinkType.Juice:
                    switch (size)
                    {
                        case DrinkSize.Small: price = 4;break;
                        case DrinkSize.Medium: price = 5;break;
                        case DrinkSize.Large: price = 6;break;
                    }
                    break;
                case DrinkType.Water:
                    switch (size)
                    {
                        case DrinkSize.Small: price = 1;break;
                        case DrinkSize.Medium: price = 1.5m;break;
                        case DrinkSize.Large: price = 2;break;
                    }
                    break;
                    default: price = 0; break;
                

            }
            return price;

        }
        public void UptadeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifaris#{OrderNumber} statusu:{newStatus}");
        }
        public void DisplayOrder()
        {
            Console.WriteLine($"Sifariş No: {OrderNumber}");
            Console.WriteLine($"Müştəri: {CustomerName}");
            Console.WriteLine($"İçki: {Drink}, Ölçü: {Size}");
            Console.WriteLine($"Qiymət: {Price} AZN");
            Console.WriteLine($"Status: {Status}");
        }
    }

}

