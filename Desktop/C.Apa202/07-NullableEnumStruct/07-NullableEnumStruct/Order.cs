using _07_NullableEnumStruct.Enums;
using System.Net.NetworkInformation;

namespace _07_NullableEnumStruct
{
    internal class Order
    {
        private int v1;
        private string v2;
        private DrinkType coffee;
        private DrinkSize medium;

        public Order(int v1, string v2, DrinkType coffee, DrinkSize medium)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.coffee = coffee;
            this.medium = medium;
        }

        public int Price { get; internal set; }

        internal void DisplayOrder()
        {
            
        }

        internal void UpdateStatus(OrderStatus preparing)
        {
                    }
    }
}