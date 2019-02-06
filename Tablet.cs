using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Tablet : Product
    {
        public string Size { get; set; }

        public Tablet(string name, double price, string manufacture, string size)
            : base(name, price, manufacture)
        {
            Size = size;
        }
    }
}
