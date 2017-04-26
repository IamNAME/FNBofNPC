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
       
        List<Account> LISTACCOUNT = new List<Account>();
        public Form1()
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

            act.custID = (Convert.ToInt32(CustomerID_tbx.Text));
            act.accType = savingsOrChecking_cbx.Text;
            act.openBal = Convert.ToDouble(startBalance_tbx.Text);
            // act.accNum = Convert.ToInt32(AccountNum_tbx.Text);
            //We need to figure out how to connect or add the listaccount to the appdata. Then the entire program should function correctly. Mr. Ivers said to remind him on monday that we need to go over connecting to AppData.
            try
            {
                act.accNum = LISTACCOUNT.Last().accNum + 1;
            }
            catch
            {
                act.accNum = 1;
            }
            
           LISTACCOUNT.Add(act);
            AccountNum_tbx.Text = Convert.ToString(act.accNum);


            //appdata.collect(act);
            // //APPDATA.LISTACCOUNT.Add(act);            this should add all of the informations within the textboxes to form an instance



            MessageBox.Show("The information has been stored.");

            this.Close();



        }
    }
}
