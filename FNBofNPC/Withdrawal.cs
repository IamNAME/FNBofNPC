﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    class Withdrawal : Transaction
    {
        public Withdrawal(double amt, int fromAccount)
        {
            amount = amt;
            fromAccountNumber = fromAccount;
        }
        int FromAccountNumber
        {
            set { fromAccountNumber = value; }
            get { return fromAccountNumber; }
        }
       private double Amount
        {
            set { amount = value; }
            get { return amount; }
        }

    }
}
