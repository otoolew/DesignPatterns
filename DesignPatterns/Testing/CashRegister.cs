using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Testing
{
    public class CashRegister
    {
        public static bool WithdrawCash(Account a, float amount)
        {
            var cash = a.CashValue;
          
            if ((a.CashValue - amount)>0)
            {
                return true;
            }
            return false;
        }
    }
}
