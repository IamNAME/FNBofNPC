using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstNationalBankOfNPC
{
    public partial class Form1 : Form
    {
        StreamWriter sw;
        List<Account> LISTACCOUNT = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }
        int accountNum;
        private void Form1_Load(object sender, EventArgs e)
        {

            if (LISTACCOUNT.Count > 0)
            {
                accountNum = LISTACCOUNT.Last().accNum + 1;
                AccountNum_tbx.Text = accountNum.ToString();
            }
            else
                AccountNum_tbx.Text = "1";
        }

        private void saveAndExit_btn_Click(object sender, EventArgs e)
        {

            sw = new StreamWriter(@"C:\myfiles\theAccounts.txt");


            Account act = new Account();
            LISTACCOUNT.Add(act);
            act.custID = (Convert.ToInt32(CustomerID_tbx.Text));
            act.accType = savingsOrChecking_cbx.Text;
            act.openBal = Convert.ToDouble(startBalance_tbx.Text);
            

           
           

            MessageBox.Show("The information has been stored.");

            this.Close();
           

        }
    }
}
