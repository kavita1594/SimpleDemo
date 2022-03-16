using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_GenericCollection
{
    public class Product
    {
        private int code;
        private String name;
        private double price;

        public Product(int code, string name, double price)
        {
            this.code = code;
            this.name = name;
            this.price = price;

        }
        public override string ToString()
        {
            return code + "  " + name + "  " + price;
        }
    }
}
