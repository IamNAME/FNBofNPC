using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    class Withdrawal : Transaction
    {
        public Withdrawal(decimal amt, int fromAccount)
        {
            amount = amt;
            fromAccountNumber = fromAccount;
        }
        int FromAccountNumber
        {
            set { fromAccountNumber = value; }
            get { return fromAccountNumber; }
        }
       private decimal Amount
        {
            set { amount = value; }
            get { return amount; }
        }

    }
}
