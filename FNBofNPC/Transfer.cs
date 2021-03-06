﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    class Transfer : Transaction
    {
        public Transfer (int toAccount, double amt, int fromAccount)
        {
            toAccountNumber = toAccount;
            amount = amt;
            fromAccountNumber = fromAccount;
        }
        int FromAccountNumber
        {
            set { fromAccountNumber = value; }
            get { return fromAccountNumber; }
        }
        double Amount
        {
            set { amount = value; }
            get { return amount; }
        }
        int ToAccountNumber
        {
            set { toAccountNumber = value; }
            get { return toAccountNumber; }
        }

    }
}
