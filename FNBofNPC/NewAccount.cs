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
        List<Account> LISTACCOUNT = new List<Account>();
        public frmNewAccount()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            AccountNum_tbx.Text = Convert.ToString(AppData.lastAcc().accNum + 1);
        }

        private void saveAndExit_btn_Click(object sender, EventArgs e)
        {
            Account act = new Account();
            
            act.custID = (Convert.ToInt32(CustomerID_tbx.Text));
            act.accType = savingsOrChecking_cbx.Text;
            act.openBal = Convert.ToDouble(startBalance_tbx.Text);
            AppData.saveToAccList(act);
            
            MessageBox.Show("The information has been stored.");

            AppData.saveLists();
            this.Close();
           

        }
    }
}
