using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.C1Intro
{
    class FlyWithMagic : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fllying with Magic!");
        }
    }
}
