using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adventure
{
    // Take note this class uses differnt commenting techniques
    // Actor is now only stores Data
    public abstract class Actor
    {
        // Properties are not required to encapsulate fields, they could do a calculation on other fields, or serve other purposes
        // you can also do other logic, such as validation, when a property is accessed, another useful feature.
        // https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property-in-c

        // Field -> It is private to your class and stores the actual data.
        private string _name;
        
        /*
         * Property -> When accessed it uses the underlying field but 
         * only exposes the contract, which will not be affected by the underlying field.         
         */
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        // This is an AutoProperty (C# 3.0 and higher) - which is a shorthand syntax
        // Used to generate a private field for you. The code below and the code above is the same

        public int Strength { get; set; }
        public int Defense { get; set; }
        public HealthComponent _healthBehavior = new HealthComponent(100);

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="atk"></param>
        /// <param name="def"></param>
        public Actor(string name, int atk, int def)
        {
            Name = name;
            Strength = atk;
            Defense = def;
        }

        public virtual int GetHealthPoints()
        {
            return _healthBehavior.Points;
        }

        public virtual void SubtractHealthPoints(int amount)
        {
            _healthBehavior.Points -= amount;
        }

        public virtual void AddHealthPoints(int amount)
        {
            _healthBehavior.Points -= amount;
        }
        public abstract void DefensiveAction();

     }
}
