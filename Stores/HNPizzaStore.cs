using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class HNPizzaStore : PizzaStore
    {
        public override void OrderPizza()
        {
            Console.WriteLine("Please choose a type pizza...");
            Console.WriteLine("\t1: Cheese Pizza");
            Console.WriteLine("\t2: Greek Pizza");
            Console.WriteLine("\t3: Pepperoni Pizza");

            string type = Console.ReadLine();

            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("\t Ha Noi Store");
            Console.WriteLine("-----------------------------");
            switch (type)
            {
                case "1":
                    return new HNCheesePizza();
                case "2":
                    return new HNGreekPizza();
                case "3":
                    return new HNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
