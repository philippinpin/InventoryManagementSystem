using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagement
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public decimal CalculateTotal()
        {
            return OrderItems.Sum(item => item.GetTotalPrice());
        }
        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Order ID: {OrderId}");
            Console.WriteLine("Order Items:");
            foreach (var item in OrderItems)
            {
                item.DisplayOrderItemDetails();
            }
            Console.WriteLine($"Total Order Value: {CalculateTotal():C}");
        }
        public decimal ApplyDiscount()
        {
            decimal total = CalculateTotal();
            decimal discount = 0;

            if (total > 500)
            {
                discount = total * 0.10m;
            }
            else if (total > 200)
            {
                discount = total * 0.05m;
            }

            Console.WriteLine($"Discount Applied: {discount:C}");
            return total - discount;
        }
    }
}
