using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        public override string GetDescription()
        {
            return Description;
        }
    }
}
