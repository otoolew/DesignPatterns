using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    class Chicken : Actor
    {
        public Chicken(string name, int atk, int def) : base(name, atk, def)
        {
        }

        public override void DefensiveAction()
        {
            throw new NotImplementedException();
        }
    }
}
