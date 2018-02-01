using System;
using DesignPatterns.DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest
{
    [TestClass]
    public class DesignPatternsTest
    {

        /*  
         *  The method must be decorated with the [TestMethod] attribute.
         *  The method must return void.
         *  The method cannot have parameters.
        */
        [TestMethod]
        public void Beverage_WithValidDescription_DisplaysDescription()
        {
            Beverage beverage3 = new HouseBlend();
            beverage3 = new Mocha(beverage3);
            beverage3 = new WhippedCream(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
            // arrange  
       
            Beverage houseCoffee = new HouseBlend();
            
            string expected = "House Blend Coffee";
            // act  
            houseCoffee.GetDescription();

            // assert  
            string actual = houseCoffee.GetDescription();
            Assert.AreEqual(expected, actual, "Decription not correctly inherited from Base");
        }
    }
}
