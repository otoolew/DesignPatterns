using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class HouseBlend : Beverage
    {
        
        public override string GetDescription()
        {
            Description = "House Blend Coffee";
            return Description;
        }
        public override float Cost()
        {
            return 0.89f;
        }
    }
}
