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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void saveAndExit_btn_Click(object sender, EventArgs e)
        {

            Account act = new Account();

            act.custID = (Convert.ToInt32(CustomerID_tbx.Text));
            act.accType = savingsOrChecking_cbx.Text;
            act.openBal = Convert.ToDouble(startBalance_tbx.Text);
            // act.accNum = Convert.ToInt32(AccountNum_tbx.Text);
            try
            {
                act.accNum = AppData.AccountList.Last().accNum + 1;
            }
            catch
            {
                act.accNum = 1;
            }
            AppData.AccountList.Add(act);
            AccountNum_tbx.Text = Convert.ToString(act.accNum);


            //appdata.collect(act);
            // //APPDATA.LISTACCOUNT.Add(act);            this should add all of the informations within the textboxes to form an instance
            AppData.AccountList.Add(act);
            AppData.saveToAccList(act);


            MessageBox.Show("The information has been stored.");

            this.Close();



        }

        private void startBal_lb_Click(object sender, EventArgs e)
        {

        }

        private void accountType_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
