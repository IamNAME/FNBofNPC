﻿using System;
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
            AppData.readLists();
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
            frmNewAccount accountForm = new frmNewAccount();
            accountForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            AppData.saveLists();
            Close();
        }

        private void genSample_Click(object sender, EventArgs e)
        {
            AppData.generateSampleData(10);
            MessageBox.Show("Sample data populated.");
        }

        private void dataRefresh_Click(object sender, EventArgs e)
        {
            AppData.readLists();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
