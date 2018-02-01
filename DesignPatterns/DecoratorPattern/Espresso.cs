using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class Espresso : Beverage
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
