using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FNBofNPC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AppData.loadCustList();
            //clear data grid here
            dataGridView1.DataSource = AppData.CustomerList;
        }
        private void btn1_Click(object sender, EventArgs e)
        {

        }
        private void NewCustomer_Click(object sender, EventArgs e)
        {
            NewCust customerForm = new NewCust();
            customerForm.Show();
        }

        private void NewTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction transForm = new frmTransaction();
            transForm.Show();
        }

        private void NewAccount_Click(object sender, EventArgs e)
        {
            Form1 accountForm = new Form1();
            accountForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showAccounts_Click(object sender, EventArgs e)
        {
            //clear data grid here
            AppData.loadAccountList();
            dataGridView1.DataSource = AppData.AccountList;

        }
    }
}
