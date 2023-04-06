using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class BNCheesePizza : Pizza
    {
        public BNCheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Very thin dough";
            sauce = "Very spicy sauce";
            toppings.Add("Black Olives");
            toppings.Add("Cheese");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking " + name + " in 20 mins");
        }
    }
}
