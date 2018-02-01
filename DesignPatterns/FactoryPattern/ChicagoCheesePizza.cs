using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class ChicagoCheesePizza : Pizza
    {
        protected ChicagoCheesePizza()
        {
            Name = "Chicago Style Pizza";
            Dough = "Thick Crest";
            Sauce = "Tomato";
            Toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
