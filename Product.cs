using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Product
    {
        //свойства
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

        //метод
        public double GetDiscountPrice(User user) //сюда передаем копию ссылки на объект
        {
            if (user.Spent < 300)
            {
                return Price;
            }
            if (user.Spent < 1000)
            {
                return 0.9 * Price;
            }
            return 0.8 * Price;
        }

        public virtual void DispInfoProduct()
        {
            Console.WriteLine("Тип товара");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine($"Цена: {Price}");
            Console.WriteLine("Производитель: " + Manufacturer);
        }

        //Конструктор
        public Product(string name, double price, string manufacture)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacture;
        }
    }
}
