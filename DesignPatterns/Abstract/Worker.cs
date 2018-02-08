using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Abstract
{
    class Worker :People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public override void AbsWalk()
        {
            Console.WriteLine("Worker Walk");
        }
        
    }
}
