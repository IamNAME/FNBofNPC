using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNBofNPC
{
    class Customer
    {
        private string _cID; // Customer ID
        private string _fName; // First Name
        private string _lName; // Last Name
        private string _add; // address
        private string _phone; // Phone Number
        private string _altPhone; // Alternate Phone Number
        private string _email; // E-Mail
        private string _dob; // D.O.B
        private string _income; // Income
        private string _ssNum; //Social Security Number
        private string _emp; // Employer
        private string _mother; //Mother's Maiden Name
        private string _citi; // Citicenship

        public string CID
        {
            get { return _cID; }
            set { _cID = value; }
        }
        public string FNAME
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string LNAME
        {
            get { return _lName; }
            set { _lName = value; }
        }
        public string ADD
        {
            get { return _add; }
            set { _add = value; }
        }
        public string PHONE
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string ALTPHONE
        {
            get { return _altPhone; }
            set { _altPhone = value; }
        }
        public string EMAIL
        {
            get { return _email; }
            set { _email = value; }
        }
        public string DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string INCOME
        {
            get { return _income; }
            set { _income = value; }
        }
        public string SSNUM
        {
            get { return _ssNum; }
            set { _ssNum = value; }
        }
        public string EMP
        {
            get { return _emp; }
            set { _emp = value; }
        }
        public string MOTHER
        {
            get { return _mother; }
            set { _mother = value; }
        }
        public string CITI
        {
            get { return _citi; }
            set { _citi = value; }

        }

    }
}
