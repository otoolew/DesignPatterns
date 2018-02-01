using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.C1Intro
{
    class Ghost
    {
        delegate IFlyBehavior Flying();
        IFlyBehavior FlyBehavior;

        public Ghost()
        {
            FlyBehavior = new FlyWithMagic();
        }
        public void StartFlying()
        {
            
            FlyBehavior.Fly();
        }
    }
}
