using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            Name = "NY Style Pizza";
            Dough = "Thin Crest";
            Sauce = "Marinara";
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
