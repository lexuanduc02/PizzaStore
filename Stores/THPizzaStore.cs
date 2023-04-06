using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class THPizzaStore : PizzaStore
    {
        public override void OrderPizza()
        {
            Console.WriteLine("Please choose a type pizza...");
            Console.WriteLine("\t1: Cheese Pizza");
            Console.WriteLine("\t2: Greek Pizza");

            string type = Console.ReadLine();

            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("\t Thanh Hoa Store");
            Console.WriteLine("----------------------------");

            switch (type)
            {
                case "1":
                    return new THCheesePizza();
                case "2":
                    return new THPepperoniPizza();
                default: 
                    return null;
            }
        }
    }
}
