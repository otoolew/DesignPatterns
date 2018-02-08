using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract
{
    class Customer : People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public override void WalkBase()
        {
            Console.WriteLine("diff walk:");
        }

        public override void AbsWalk()
        {
            Console.WriteLine("Customer Walk");
        }
    }
}
