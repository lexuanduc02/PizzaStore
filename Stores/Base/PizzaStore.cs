using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
