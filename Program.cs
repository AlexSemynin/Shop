using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Вася", "50letOktyabrya", 10000, 0); //Эта информация берется из БД

            Telephone iphone = new Telephone("IPhone XV", 7000, "Apple", false);
            Telephone samsung = new Telephone("Galaxy XIV", 11000, "Samsung", false);      //Эта тоже, наверн)
            Tablet tablet1 = new Tablet("OneXRSERT", 10000, "Samsung", "10x10x2");
            Laptop laptop1 = new Laptop("Mac", 2000000000, "Apple", "Steel");

            //upcast т.к. тип массива Product, а я пихаю туда значения других типов, !но! дочерних 
            Product[] products = new Product[]
            {
                iphone,
                samsung,
                tablet1,
                laptop1
            };
            
        }
        public void Assortiment(Product[] products)
        {
            Console.WriteLine("Список товаров:");
            for(int i = 0; i < products.Length; i++)
            {
                products[i].DispInfoProduct();
                Console.WriteLine("_________________");
            } 
        }
    }
}
