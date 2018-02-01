using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class Espresso : Beverage
    {
        public override float Cost()
        {
            return 1.99f;
        }

        public override string GetDescription()
        {
            return Description = "Espresso";
        }
    }
}
