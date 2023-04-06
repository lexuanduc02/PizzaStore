using PizzaStore.Store;
using System;

namespace PizzaStore
{ 
    class Program
    {
        static void Main(string[] args)
        {
            OrderPizza();
        }

        public static void OrderPizza()
        {
            Console.WriteLine("Please choose a pizza store...");
            Console.WriteLine("\t1: Ha Noi");
            Console.WriteLine("\t2: Thanh Hoa");
            Console.WriteLine("\t3: Bac Ninh");

            string store = Console.ReadLine();
            PizzaStore pizzaStore;

            switch(store)
            {
                case "1":
                    pizzaStore = new HNPizzaStore();
                    pizzaStore.OrderPizza();
                    break;
                case "2":
                    pizzaStore = new THPizzaStore();
                    pizzaStore.OrderPizza();
                    break;
                case "3":
                    pizzaStore = new BNPizzaStore();
                    pizzaStore.OrderPizza();
                    break;
                default:
                    Console.WriteLine("Coming soon");
                    break;
            }
        }
    }
}


