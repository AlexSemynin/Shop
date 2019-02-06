using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Telephone : Product
    {
        public bool HaveButtons { get; set; }

        //Конструктор от родителя
        public Telephone(string name, double price, string manufacture, bool haveButtons) 
            : base(name, price, manufacture)
        {
            HaveButtons = haveButtons;
        }
    }
}
