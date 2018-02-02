using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesignPatterns.Adventure.HealthComponent;

namespace DesignPatterns.Adventure
{
    public enum HealthStatus { Healthy, Stunned}
    public class HealthComponent
    {
        public int MaxHPValue { get; set; }
        public int Points { get; set; }
        public HealthStatus healthStatus;
        public HealthComponent(int maxHP)
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
