using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    class Deposit : Transaction
    {
        public Deposit (int accountNum, decimal depositAmt)
        {
            toAccountNumber = accountNum;
            amount = depositAmt;
        }
        
        int ToAccountNumber
        {
            set { toAccountNumber = value; }
            get { return toAccountNumber; }
        }
       decimal Amount
        {
            set { amount = value; }
            get { return amount; }
        }

    }
}
