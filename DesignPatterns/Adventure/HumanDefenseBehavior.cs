using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    public class HumanDefenseBehavior : IDefend
    {
        public void Defend()
        {
            Console.WriteLine("Hold Shield High!");
        }
    }
}
