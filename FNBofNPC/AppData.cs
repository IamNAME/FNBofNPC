using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FNBofNPC
{
    class AppData
    {
        static string _appDir = @"C:\myfiles\FNBofNPC\";
        static string _customerListName = "CData.txt";
        static string _accountListName = "AData.txt";
        static string _transactionListName = "TData.txt";
        public static List<Account> AccountList = new List<Account>();
        public static List<Customer> CustomerList = new List<Customer>();

        //
        public static string _AppDir
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

        public static string _cListName
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

        public static string _aListName
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

        public static string _tListName
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

       public static void saveToCustList(Customer cust)
        {
            StreamWriter sw = new StreamWriter(AppData._AppDir + AppData._customerListName, true);


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

        public static void saveToAccList(Account act)
        {
            StreamWriter swa = new StreamWriter(AppData._AppDir + AppData._accountListName, true);

            swa.WriteLine(
                act.custID + ","
                + act.accNum + ", "
                + act.accType + ", "
                + act.openBal
                );
            swa.Close();
            return;
        }
    }
}