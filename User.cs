using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_2_Polimorfizm
{
    class User
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; }
        
        //Конструктор
        public User(string name, string adr, double balance, double spent)
        {
            Name = name;
            Adress = adr;
            Balance = balance;
            Spent = spent;
        }

        //метод
        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
