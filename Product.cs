using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Manufacturer { get; set; }

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
    }
}
