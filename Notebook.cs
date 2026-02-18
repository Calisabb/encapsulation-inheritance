using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_inheritance
{
    internal class Notebook : Product
    {
        byte _ram;
        public int storage;
        public byte Ram
        {
            get
            { 
                return _ram;
            }

            set
            {
                if (value % 4 == 0 && value <= 64)
                {
                    _ram = value;

                }
                else
                {
                    Console.WriteLine("ele ram olmur");
                }


            }
        }

        public Notebook(byte ram, string name, int count, int price, int storage):base(name, count, price)
        {
            Ram = ram;
            this.storage = storage;

        }

        public void ShowFullData()
        {
            Console.WriteLine($"Ram:{Ram}, Name:{name}, Count:{count}, Price:{Price}, Storage:{storage}");
        
        }

        public string GetFullInfo()
        {
            return $"{Ram}, {name}, {count}, {Price}, {storage}";
        }




    }
}
