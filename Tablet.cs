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
        public override void DispInfoProduct()
        {
            Console.WriteLine("Планшет:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine($"Наличие кнопок: {Size}");
        }
    }
}
