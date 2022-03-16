using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> p = new List<Product>();
            Product p1 = new Product(101, "abc", 1000);
            Product p2 = new Product(102, "aaa", 2000);
            Product p3 = new Product(103, "xyz" ,3000);
            p.Add(p1);
            p.Add(p2);
            p.Add(p3);

            foreach(Product i in p)
            {
                Console.WriteLine(i);
            }
        }
    }
}
