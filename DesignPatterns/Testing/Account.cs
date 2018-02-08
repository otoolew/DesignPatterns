using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Testing
{
    public class Account
    {
        public string Name { get; set; }
        public int CashValue { get; set; }
        public Account()
        {
            Name = "Joe";
            CashValue = 100;
        }
    }
}
