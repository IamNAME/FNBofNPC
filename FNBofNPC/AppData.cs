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
        static string _customerFileName = "CData.txt";
        static string _accountFileName = "AData.txt";
        static string _transactionFileName = "TData.txt";

        static List<Customer> _custList = new List<Customer>();
        static List<Account> _accList = new List<Account>();
        static List<Transaction> _transList = new List<Transaction>();



        public static void readLists()
            //reads storage files into internal lists
        {
            if(!File.Exists(_appDirectory + @"\" + _customerFileName))
            {
                File.Create(_appDirectory + @"\" + _customerFileName);
            }
            if(!File.Exists(_appDirectory + @"\" + _accountFileName))
            {
                File.Create(_appDirectory + @"\" + _accountFileName);
            }
            if(!File.Exists(_appDirectory + @"\" + _transactionFileName))
            {
                File.Create(_appDirectory + @"\" + _transactionFileName);
            }

            StreamReader sr1 = new StreamReader(_appDirectory + @"\" + _customerFileName);
            StreamReader sr2 = new StreamReader(_appDirectory + @"\" + _accountFileName);
            StreamReader sr3 = new StreamReader(_appDirectory + @"\" + _transactionFileName);

            Customer importCust = new Customer();
            Account importAcc = new Account();
            Transaction importTrans = new Transaction();


            string line1;
            string[] row1 = new string[20];
            while ((line1 = sr1.ReadLine()) != null)
            {
                row1 = line1.Split(',');
                importCust.CID = Convert.ToInt32(row1[0]);
                importCust.FNAME = row1[1];
                importCust.LNAME = row1[2];
                importCust.SSNUM = row1[3];
                importCust.DOB = row1[4];
                importCust.CITY = row1[5];
                importCust.STATE = row1[6];
                importCust.ZIP = row1[7];
                importCust.PHONE = row1[8];
                importCust.ALTPHONE = row1[9];
                importCust.DOB = row1[10];
                importCust.EMAIL = row1[11];
                importCust.EMP = row1[12];
                importCust.DLNUMBER = row1[13];
                importCust.DLCITY = row1[14];
                importCust.DLSTATE = row1[15];
                importCust.DLZIP = row1[16];
                importCust.EXPDATE = row1[17];
                importCust.CITI = row1[18];
                importCust.MOTHER = row1[19];
                _custList.Add(importCust);
            }

            string line2;
            string[] row2 = new string[4];
            while ((line2 = sr2.ReadLine()) != null)
            {
                row2 = line2.Split(',');
                importAcc.accNum = Convert.ToInt32(row2[0]);
                importAcc.accType = row2[1];
                importAcc.custID = Convert.ToInt32(row2[2]);
                importAcc.openBal = Convert.ToInt32(row2[2]);
                _accList.Add(importAcc);
            }

            string line3;
            string[] row3 = new string[4];
            while ((line3 = sr3.ReadLine()) != null)
            {
                row3 = line3.Split(',');
                importTrans.fromAccountNumber = Convert.ToInt16(row3[0]);
                importTrans.amount = Convert.ToInt16(row3[1]);
                importTrans.toAccountNumber = Convert.ToInt16(row3[2]);

                switch (row3[3])
                {
                    case "Deposit":
                        Deposit dImport = new Deposit(importTrans.toAccountNumber,importTrans.amount);
                        _transList.Add(dImport);
                        break;
                    case "Withdrawal":
                        Withdrawal wImport = new Withdrawal(importTrans.amount, importTrans.fromAccountNumber);
                        _transList.Add(wImport);
                        break;
                    case "Transfer":
                        Transfer tImport = new Transfer(importTrans.toAccountNumber, importTrans.amount, importTrans.fromAccountNumber);
                        _transList.Add(tImport);
                        break;
                }
            }
            sr1.Close();
            sr2.Close();
            sr3.Close();

        }

        public static void generateSampleData(int samples)
            //generates a number of samples for all three lists
        {
            StreamWriter sw1 = new StreamWriter(_appDirectory + @"\" + _customerFileName, true);
            StreamWriter sw2 = new StreamWriter(_appDirectory + @"\" + _accountFileName, true);
            StreamWriter sw3 = new StreamWriter(_appDirectory + @"\" + _transactionFileName, true);

            for (int i = 0; i <= samples; i++)
            {
                
                sw1.WriteLine(i 
                    + ",Jim" + i 
                    + ",Person" + i 
                    + ",123-45-6789,01-01-1991," + i + " Road Street,Cityville,AR,12345,123-456-7890,098-765-4321,sample@sample.com,Bossman,12345123,Cityville,AR,12345,01/2019,USA,Mom");
                sw2.WriteLine(i + ","
                    + "Checking" + ","
                    + i + ","
                    + "10000");
                sw3.WriteLine(i +","
                    + 100 + ","
                    + i+1
                    + ",Transfer");
                
            }
            sw1.Close();
            sw2.Close();
            sw3.Close();
        }

        public static void saveToCustList(Customer cust)
            //adds a customer to internal list
        {
            _custList.Add(cust);
            return;
        }
        public static Customer lastCust()
            //grabs info from last customer in internal list
        {
            return _custList.Last();
        }
        public static List<Customer> getCustList()
            //gets customer list
        {
            return _custList;
        }

        public static void saveToAccList(Account acc)
            //adds an account to internal list
        {
            _accList.Add(acc);
            return;
        }
        public static Account lastAcc()
            //grabs info from last account in internal list
        {
            return _accList.Last();
        }
        public static void performTransaction(Transaction trans)
            //performs given transaction
        {
            switch (trans.GetType().ToString())
            {
                case "FNBofNPC.Withdrawal":
                    foreach (Account acc in _accList)
                    {
                        if (acc.accNum == trans.fromAccountNumber)
                        {
                            acc.openBal -= trans.amount;
                        }
                    }
                    break;
                case "FNBofNPC.Transfer":
                    foreach (Account acc in _accList)
                    {
                        if (acc.accNum == trans.fromAccountNumber)
                        {
                            acc.openBal -= trans.amount;
                        }
                        if (acc.accNum == trans.toAccountNumber)
                        {
                            acc.openBal += trans.amount;
                        }
                    }
                    break;
                case "FNBofNPC.Deposit":
                    foreach (Account acc in _accList)
                    {
                        if (acc.accNum == trans.toAccountNumber)
                        {
                            acc.openBal += trans.amount;
                        }
                    }
                    break;
            }
        }
        public static List<Account> getAccList()
            //gets account list
        {
            return _accList;
        }

        public static void saveToTransList(Transaction trans)
            //adds a transaction to internal list
        {
            _transList.Add(trans);
            return;
        }
        public static Transaction lastTrans()
            //grabs info from last transaction in internal list
        {
            return _transList.Last();
        }
        public static List<Transaction> getTransList()
            //gets transaction list
        {
            return _transList;
        }

        public static void saveLists()
            //writes internal lists to storage files (!!DO NOT USE BEFORE readLists!!)
        {
            StreamWriter sw1 = new StreamWriter(_appDirectory + @"\" + _customerFileName, false);
            StreamWriter sw2 = new StreamWriter(_appDirectory + @"\" + _accountFileName, false);
            StreamWriter sw3 = new StreamWriter(_appDirectory + @"\" + _transactionFileName, false);

            foreach(Customer cust in _custList)
            {
                sw1.WriteLine(cust.CID + ","
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
                   + cust.DLZIP + ","
                   + cust.EXPDATE + ","
                   + cust.CITI + ","
                   + cust.MOTHER);
            }
            sw1.Close();
            foreach(Account acc in _accList)
            {
                sw2.WriteLine(acc.accNum + ","
                + acc.accType + ","
                + acc.custID + ","
                + acc.openBal);
            }
            sw2.Close();
            foreach(Transaction trans in _transList)
            {
                switch (trans.GetType().ToString())
                {
                    case "Withdrawal":
                        sw3.WriteLine(trans.fromAccountNumber + ","
                + trans.amount + ","
                + "" + ",Withdrawal");
                        break;
                    case "Transfer":
                        sw3.WriteLine(trans.fromAccountNumber + ","
                + trans.amount + ","
                + trans.toAccountNumber + ",Transfer");
                        break;
                    case "Deposit":
                        sw3.WriteLine("" + ","
                + trans.amount + ","
                + trans.toAccountNumber + ",Deposit");
                        break;
                }
            }
            sw3.Close();
        }

    }
}
