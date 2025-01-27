using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymanagement
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void DisplayProductDeetails()
        {
            Console.WriteLine($"Prodeuct ID: {ProductId}, Name: {Name}, Price: {Price}");
        }
    }
}