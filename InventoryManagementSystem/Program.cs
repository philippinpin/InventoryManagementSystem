using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product { ProductId = 1, Name = "TV", Price = 700m };
            var product2 = new Product { ProductId = 2, Name = "HDD Card", Price = 230m };
            var product3 = new Product { ProductId = 3, Name = "Headset", Price = 80m };

            var orderItem1 = new OrderItem { Product = product1, Quantity = 5 };
            var orderItem2 = new OrderItem { Product = product2, Quantity = 30 };
            var orderItem3 = new OrderItem { Product = product3, Quantity = 25 };

            var order = new Order { OrderId = 1012321 };
            order.AddOrderItem(orderItem1);
            order.AddOrderItem(orderItem2);
            order.AddOrderItem(orderItem3);

            order.DisplayOrderDetails();

            decimal finalTotal = order.ApplyDiscount();
            Console.WriteLine($"Final Total After Discount: {finalTotal:C}");
        }
    }
}