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
        //public static void loadStuff()
        //{
        //    loadAccountList();
        //    loadCustList();
        //    //loadTransactionList();

        //}


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

        //public static void loadLastCust()
        //{
        //    Customer lastCust = new Customer();
        //    StreamReader sr = new StreamReader(@"C:\myfiles\FNBofNPC\CData.txt");
        //    string record = sr.ReadLine();
        //    string[] person = record.Split(',');
        //    lastCust.CID = Convert.ToInt32(person[0]);
        //}

        public static void loadCustList()
        {

           
            StreamReader sr = new StreamReader(@"C:\myfiles\FNBofNPC\CData.txt");
            while (!sr.EndOfStream)
            {
                Customer cust = new Customer();
                string record = sr.ReadLine();
                string[] person = record.Split(',');
                cust.CID = Convert.ToInt32(person[0]);
                cust.FNAME = person[1];
                cust.LNAME = person[2];
                cust.SSNUM = person[3];
                cust.DOB = person[4];
                cust.ADD = person[5];
                cust.CITY = person[6];
                cust.STATE = person[7];
                cust.ZIP = person[8];
                cust.PHONE = person[9];
                cust.ALTPHONE = person[10];
                cust.EMAIL = person[11];
                cust.EMP = person[12];
                cust.DLNUMBER = person[13];
                cust.DLCITY = person[14];
                cust.DLSTATE = person[15];
                cust.EXPDATE = person[16];
                cust.CITI = person[17];
                cust.MOTHER = person[18];
                CustomerList.Add(cust);
            }
            sr.Close();


        }


        public static void loadAccountList()
        {


            StreamReader sr = new StreamReader(@"C:\myfiles\FNBofNPC\AData.txt");
            while (!sr.EndOfStream)
            {
                Account act = new Account();
                string record = sr.ReadLine();
                string[] monies = record.Split(',');
                act.custID = Convert.ToInt32(monies[0]);
                act.accNum = Convert.ToInt32(monies[1]);
                act.accType = monies[2];
                act.openBal = Convert.ToInt32(monies[3]);
                AccountList.Add(act);
            }
            sr.Close();
        }


        public static void saveToAccList(Account act)
        {
            StreamWriter swa = new StreamWriter(AppData._AppDir + AppData._accountListName, true);

            swa.WriteLine(
                act.custID + ", "
                + act.accNum + ", "
                + act.accType + ", "
                + act.openBal
                );
            swa.Close();
            return;
        }
    }
}