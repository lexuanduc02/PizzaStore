using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class BNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("\t Bac Ninh Store");
            Console.WriteLine("----------------------------");

            switch (type)
            {
                case "cheese":
                    return new BNCheesePizza();
                case "greek":
                    return new BNGreekPizza();
                case "pepperoni":
                    return new BNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
