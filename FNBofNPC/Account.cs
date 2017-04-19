using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalBankOfNPC
{
    class Account
    {
        int _custID;            //customer ID
        int _accNum;            //account number
        double _openBal;        //opening balance
        string _accTy;          //account type
        

        public int custID
        {
            get
            {
                return _custID;
            }
            set
            {
                _custID = value;
            }
        }
        public int accNum
        {
            get
            {
                return _accNum;
            }
            set
            {
                _accNum = value;
            }
        }
        public double openBal
        {
            get
            {
                return _openBal;
            }
            set
            {
                _openBal = value;
            }
        }
       
        public string accType
        {
            get
            {
                return _accTy;
            }
            set
            {
                _accTy = value;
            }
        }
    }
}
