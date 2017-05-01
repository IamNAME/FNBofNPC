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
        static string _appDirectory = @"C:\myfiles\FNBofNPC";
        static string _customerListName = @"C:\myfiles\FNBofNPC\CData.txt";
        static string _accountListName = @"C:\myfiles\FNBofNPC\AData.txt";
        static string _transactionListName = "TData.txt";
        public static List<Account> AccountList = new List<Account>();
        public static List<Customer> CustomerList = new List<Customer>();




        public static void saveToCustList(Customer cust)
        {
                StreamWriter sw = new StreamWriter(_appDirectory + @"\" + _customerListName, true);


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

        void saveToAccList(Account acc)
        {
            return;
        }

        void saveToTransList(Transaction trans)
        {
            return;
        }
    }
}
