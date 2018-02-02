using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Adventure.Health;

namespace DesignPatterns.Adventure
{
    public enum HealthStatus { Healthy, Stunned}
    class Health
    {
        public int MaxHPValue { get; set; }
        public int Points { get; set; }
        public HealthStatus healthStatus;
        public Health(int maxHP)
        {
            healthStatus = HealthStatus.Healthy;
            MaxHPValue = maxHP;
            Points = maxHP;
        }
        public void SubtractHealthPoints(int amount)
        {
            Points -= amount;
        }
    }
}
