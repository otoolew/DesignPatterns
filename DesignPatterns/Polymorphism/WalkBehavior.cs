using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.C1Intro
{
    class WalkBehavior : IMove
    {
        public void Move()
        {
            Console.WriteLine("I am Walking.");
        }
    }
}
