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
        static string _customerListName = "CData.txt";
        static string _accountListName = "AData.txt";
        static string _transactionListName = "TData.txt";

        public static void generateSampleData(int samples)//generates a number of samples for all three lists
        {
            StreamWriter sw1 = new StreamWriter(_appDirectory + @"\" + _customerListName, true);
            StreamWriter sw2 = new StreamWriter(_appDirectory + @"\" + _accountListName, true);
            StreamWriter sw3 = new StreamWriter(_appDirectory + @"\" + _transactionListName, true);

            for (int i = 0; i < samples; i++)
            {
                
                sw1.WriteLine(i 
                    + ",Jim" + i 
                    + ",Person" + i 
                    + ",123-45-6789,01-01-1991," + i + " Road Street,Cityville,AR,12345,123-456-7890,098-765-4321,sample@sample.com,Bossman,12345123,Cityville,AR,01/2019,USA,Mom");
                sw2.WriteLine(i + ","
                    + "Checking" + ","
                    + i + ","
                    + "10000");
                sw3.WriteLine(i +","
                    + 100 + ","
                    + i+1);
                
            }
            sw1.Close();
            sw2.Close();
            sw3.Close();
        }

        public static void saveToCustList(Customer cust)//writes customer list to directory defined in AppData
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

        Customer loadLastCust()//grabs info from last customer
        {
            Customer placeholder = new Customer();
            placeholder.CID = "1";
            return placeholder;
        }

        void saveToAccList(Account acc)
        {
            StreamWriter sw = new StreamWriter(_appDirectory + @"\" + _accountListName, true);
            sw.WriteLine(acc.accNum + ","
                + acc.accType + ","
                + acc.custID + ","
                + acc.openBal);
            sw.Close();
            return;
        }

        void saveToTransList(Transaction trans)
        {
            StreamWriter sw = new StreamWriter(_appDirectory + @"\" + _transactionListName, true);
            sw.WriteLine(trans.fromAccountNumber + ","
                + trans.amount + ","
                + trans.toAccountNumber);
            sw.Close();
            return;
        }
    }
}
