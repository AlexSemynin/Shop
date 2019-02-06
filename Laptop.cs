using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Laptop : Product
    {
        public string Material { get; set; }
        public Laptop(string name, double price, string manufacture, string material)
            : base(name, price, manufacture)
        {
            Material = material;
        }
    }
}
