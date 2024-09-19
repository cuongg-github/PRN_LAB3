using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Product
    {
        private string name { get; set; }
        private double cost { get; set; }
        private int quantity { get; set; }
        public Product( string name, double cost, int quantity) {
            this.name = name;
            this.cost = cost;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return $"Product name {name} with cost {cost}$ have {quantity}";
        }

    }
    internal class Q2
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("iphone", 150.48, 100));
            list.Add(new Product("samsung", 98, 100));
            list.Add(new Product("lenovo", 50.5, 100));
            list.Add(new Product("asus", 200, 50));
            list.Add(new Product("macbook", 190, 40));
            foreach (Product p in list) { 
                Console.WriteLine(p.ToString());
            }
        }
    }
}
