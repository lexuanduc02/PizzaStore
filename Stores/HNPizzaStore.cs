using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class HNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("\t Ha Noi Store");
            Console.WriteLine("-----------------------------");
            switch (type)
            {
                case "cheese":
                    return new HNCheesePizza();
                case "greek":
                    return new HNGreekPizza();
                case "pepperoni":
                    return new HNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
