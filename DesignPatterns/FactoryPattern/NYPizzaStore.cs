using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {

        public override Pizza CreatePizza(string item)
        {
            Pizza pizza = new NYCheesePizza();
            if (item.Equals("Cheese"))
            {
                return pizza;
            }
            else if (item.Equals("Veggie"))
            {
                return pizza;
            }
            else if (item.Equals("Meat Lover"))
            {
                return pizza;
            }
            else if (item.Equals("Pepperoni"))
            {
                return pizza;
            }
            else return pizza;
        }
    }
}
