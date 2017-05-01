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

namespace FNBofNPC
{
    public partial class frmNewAccount : Form
    {
        StreamWriter sw;
        List<Account> LISTACCOUNT = new List<Account>();
        public frmNewAccount()
        {
            InitializeComponent();
        }
        int accountNum;
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void saveAndExit_btn_Click(object sender, EventArgs e)
        {

          


            Account act = new Account();
            LISTACCOUNT.Add(act);
            act.custID = (Convert.ToInt32(CustomerID_tbx.Text));
            act.accType = savingsOrChecking_cbx.Text;
            act.openBal = Convert.ToDouble(startBalance_tbx.Text);


            AppData.AccountList.Add(act);
           

            MessageBox.Show("The information has been stored.");

            this.Close();
           

        }

        private void startBalance_tbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void startBal_lb_Click(object sender, EventArgs e)
        {

        }

        private void accountType_lb_Click(object sender, EventArgs e)
        {

        }

        private void AccountNum_tbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
