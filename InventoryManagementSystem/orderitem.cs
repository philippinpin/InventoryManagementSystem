using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagement
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetTotalPrice()
        {
            return Product.Price * Quantity;
        }
        public void DisplayOrderItemDetails()
        {
            Console.WriteLine($"Product: {Product.Name}, Quantity: {Quantity}, Total: {GetTotalPrice():C}");
        }
    }
}
