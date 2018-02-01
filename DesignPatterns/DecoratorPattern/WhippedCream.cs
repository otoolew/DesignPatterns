using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public class WhippedCream : CondimentDecorator
    {
        Beverage _Beverage;
        public WhippedCream(Beverage beverage)
        {
            _Beverage = beverage;
        }
        public override float Cost()
        {
            return _Beverage.Cost() + 0.12f;
        }

        public override string GetDescription()
        {
            return _Beverage.GetDescription() + ", Whipped Cream";
        }
    }
}
