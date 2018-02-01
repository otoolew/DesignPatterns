using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Beverage
    {
        public string Description;      
        public abstract string GetDescription();

        public abstract float Cost();
    }
}
