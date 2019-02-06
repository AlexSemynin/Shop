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
        //переопределенный метод
        public override void DispInfoProduct()
        {
            Console.WriteLine("Телефон:");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine("Производитель: " + Manufacturer);
            Console.WriteLine($"Наличие кнопок: {HaveButtons}");
        }
    }
}
