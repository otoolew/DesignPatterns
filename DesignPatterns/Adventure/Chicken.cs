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

        public override void AddHealthPoints(int amount)
        {
            throw new NotImplementedException();
        }

        public override void DefensiveAction()
        {
            throw new NotImplementedException();
        }

        public override int GetHealthPoints()
        {
            throw new NotImplementedException();
        }

        public override void SubtractHealthPoints(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
