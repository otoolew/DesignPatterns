using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    public class OrcDefenseBehavior : IDefend
    {
        public void Defend()
        {
            Console.WriteLine("Stands its ground.");
        }
    }
}
