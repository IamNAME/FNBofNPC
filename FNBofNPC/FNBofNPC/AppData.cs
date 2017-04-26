using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FNBofNPC
{
    abstract class AppData
    {
        string _appDirectory = @"C:\myfiles\FNBofNPC";
        string _customerListName = "CData.txt";
        string _accountListName = "AData.txt";
        string _transactionListName = "TData.txt";

        public string _appDir
        {
            get
            {
                return _appDir;
            }
            set
            {
                _appDir = value;
            }
        }

        public string _cListName
        {
            get
            {
                return _cListName;
            }
            set
            {
                _cListName = value;
            }
        }

        public string _aListName
        {
            get
            {
                return _aListName;
            }
            set
            {
                _aListName = value;
            }
        }

        public string _tListName
        {
            get
            {
                return _tListName;
            }
            set
            {
                _tListName = value;
            }
        }

        void saveToCustList(Customer cust)
        {
                StreamWriter sw = new StreamWriter(_appDir + @"\" + _customerListName);


                sw.WriteLine(cust.CID + ","
                    + cust.FNAME + ","
                    + cust.LNAME + "," 
                    + cust.SSNUM + ","
                    + cust.DOB + ","
                    + cust.ADD + ","
                    + cust.CITY + ","
                    + cust.STATE + ","
                    + cust.ZIP + ","
                    + cust.PHONE + ","
                    + cust.ALTPHONE + ","
                    + cust.EMAIL + ","
                    + cust.EMP + ","
                    + cust.DLNUMBER + ","
                    + cust.DLCITY + ","
                    + cust.DLSTATE + ","
                    + cust.EXPDATE + ","
                    + cust.CITI + ","
                    + cust.MOTHER);
                sw.Close();
            return;
        }

        void loadLastCust()
        {

        }

        void saveToAccList(Account act)
        {

            StreamWriter asw = new StreamWriter(_appDir + @"\" + _accountListName);
            asw.WriteLine(act.accNum+","
                +act.custID + ","
                + act.accType + ","
                + act.openBal);
            asw.Close();
                   
            return;
        }
    }
}
