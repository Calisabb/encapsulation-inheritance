using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_inheritance
{
    internal class Product
    {
        public string name;
        public string description;
        public int count;
        public bool isStock;
        int _price;



        public int Price 
        {
            get
            { 
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("qiymet sifirdan boyuk olmalidir");
                }
                else
                { 
                    _price = value;
                }

            }
        }
        public Product(string name, int count, int price)
        {
            this.name = name;
            this.count = count;
            Price = price;
        }

        public void Sale(bool isStock)
        {
            if (isStock == false)
            {
                Console.WriteLine("mehsul stockda yoxdur");

            }

        }




    }
}
