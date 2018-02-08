using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract
{
    public abstract class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public abstract void AbsWalk();
 
        public virtual void WalkBase()
        {
            Console.WriteLine("Base Walk");
        }

    }
}
