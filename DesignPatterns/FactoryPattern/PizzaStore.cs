using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class PizzaStore
    {
        // This has no idea what pizza it is creating!
        public Pizza OrderPizza(string item)
        {
            Pizza pizza;
            pizza = CreatePizza(item);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;       
        }
        public abstract Pizza CreatePizza(string type); // This is our Factory Method
    }
}
