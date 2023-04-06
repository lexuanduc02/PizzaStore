using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Store
{
    public class THPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("\t Thanh Hoa Store");
            Console.WriteLine("----------------------------");

            switch (type)
            {
                case "cheese":
                    return new THCheesePizza();
                case "greek":
                    return new THPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
