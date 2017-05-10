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
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void transactionTypeCmBx_SelectedValueChanged(object sender, EventArgs e)
        {
            if (transactionTypeCmBx.Text == "Deposit")
            {
                toAccountLbl.Show();
                toAccountTbx.Show();
                amtLbl.Show();
                amtTbx.Show();
                fromAccountLbl.Hide();
                fromAccountTbx.Hide();
                saveBtn.Show();
            }
            else if (transactionTypeCmBx.Text == "Withdrawal")
            {
                toAccountLbl.Hide();
                toAccountTbx.Hide();
                amtLbl.Show();
                amtTbx.Show();
                fromAccountLbl.Show();
                fromAccountTbx.Show();
                saveBtn.Show();
            }
            else if (transactionTypeCmBx.Text == "Transfer")
            {
                toAccountLbl.Show();
                toAccountTbx.Show();
                amtLbl.Show();
                amtTbx.Show();
                fromAccountLbl.Show();
                fromAccountTbx.Show();
                saveBtn.Show();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (transactionTypeCmBx.Text == "Deposit")
            {
                try
                {
                    Deposit deposit = new Deposit(Convert.ToInt32(toAccountTbx.Text), Convert.ToDouble(amtTbx.Text));
                    AppData.performTransaction(deposit);
                    AppData.saveToTransList(deposit);
                    AppData.saveLists();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please be sure all fields have been filled out, and that all account numbers are valid.");
                }
                
            }
            else if (transactionTypeCmBx.Text == "Withdrawal")
            {
                try
                {
                    Withdrawal withdrawal = new Withdrawal(Convert.ToDouble(amtTbx.Text), Convert.ToInt32(fromAccountTbx.Text));
                    AppData.performTransaction(withdrawal);
                    AppData.saveToTransList(withdrawal);
                    AppData.saveLists();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please be sure all fields have been filled out, and that all account numbers are valid.");
                }
                
            }
            else if (transactionTypeCmBx.Text == "Transfer")
            {
                try
                {
                    Transfer transfer = new Transfer(Convert.ToInt32(toAccountTbx.Text), Convert.ToDouble(amtTbx.Text), Convert.ToInt32(fromAccountTbx.Text));
                    AppData.performTransaction(transfer);
                    AppData.saveToTransList(transfer);
                    AppData.saveLists();
                    Close();
                }
                catch
                {
                    MessageBox.Show("Please be sure all fields have been filled out, and that all account numbers are valid.");
                }

            }
        }
    }
}
