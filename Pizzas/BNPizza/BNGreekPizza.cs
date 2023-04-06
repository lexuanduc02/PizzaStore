using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class BNGreekPizza : Pizza
    {
        public BNGreekPizza()
        {
            name = "Greek Pizza";
            dough = "Thin dough";
            sauce = "Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking " + name + " in 40 mins");
        }
    }
}
