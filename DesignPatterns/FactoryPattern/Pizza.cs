using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class Pizza
    {
        string name;
        string dough;
        string sauce;
        ArrayList toppings = new ArrayList();

        public string Name { get => name; set => name = value; }
        public string Dough { get => dough; set => dough = value; }
        public string Sauce { get => sauce; set => sauce = value; }
        public ArrayList Toppings { get => toppings; set => toppings = value; }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing Pizza");
            for (int i = 0; i < Toppings.Count; i++)
            {
                Console.WriteLine("    " + Toppings[i]);
            }
        }
        public virtual void Bake()
        {
            Console.WriteLine("Baking Pizza");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting Pizza");
        }
        public virtual void Box()
        {
            Console.WriteLine("Boxing Pizza");
        }
    }
}
