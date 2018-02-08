using DesignPatterns.C1Intro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Polymorphism
{
    public class FlyWithWings : IMove
    {
        public void Move()
        {
            Console.WriteLine("Flying with my wings!");
        }
    }
}
