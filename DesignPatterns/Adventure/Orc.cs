using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    public class Orc : Actor
    {
        HealthComponent _healthBehavior = new HealthComponent(100);  
        IDefend DefendBehavior = new OrcDefenseBehavior();

        public Orc(string name, int atk, int def) : base(name, atk, def)
        {
        }
        public override int GetHealthPoints()
        {
            return _healthBehavior.Points;
        }

        public override void SubtractHealthPoints(int amount)
        {
            _healthBehavior.Points -= amount;
        }

        public override void AddHealthPoints(int amount)
        {
            _healthBehavior.Points -= amount;
        }

        public override void DefensiveAction()
        {
            DefendBehavior.Defend();
        }
    }
}
