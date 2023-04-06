using PizzaStore.Store;
using System;

namespace PizzaStore
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new HNPizzaStore();
            pizzaStore.OrderPizza("cheese");
        }
    }
}


