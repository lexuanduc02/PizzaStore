using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class BNPepperoniPizza : Pizza
    {
        public BNPepperoniPizza()
        {
            name = "Pepperoni Pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
