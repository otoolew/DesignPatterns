using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    class Mocha : CondimentDecorator
    {
        Beverage _Beverage;

        public Mocha(Beverage beverage)
        {
            _Beverage = beverage;
        }
        public override float Cost()
        {
            return .20f + _Beverage.Cost(); 
        }

        public override string GetDescription()
        {
            return _Beverage.GetDescription() + ", Mocha";
        }
    }
}
