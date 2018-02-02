using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    internal class Human : Actor
    {
        //HealthComponent _healthBehavior = new HealthComponent(100);
        IDefend DefendBehavior = new HumanDefenseBehavior();

        public Human(string name, int atk, int def) : base(name, atk, def)
        {
        }
            
        public override void DefensiveAction()
        {
            DefendBehavior.Defend();
        }
    }
}
