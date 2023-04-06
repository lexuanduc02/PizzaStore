using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public abstract void OrderPizza();

        protected abstract Pizza CreatePizza(string type);
    }
}
