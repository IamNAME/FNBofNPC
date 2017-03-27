using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    abstract class AppData
    {
        string _appDirectory = @"C:\myfiles\FNBOfNPC";
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
    }
}
