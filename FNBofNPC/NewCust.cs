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
    public partial class NewCust : Form
    {
        public NewCust()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Customer cs = new Customer();
            tbxCustID.Text = Convert.ToString(cs.CID);
            cs.CID = Convert.ToInt32(tbxCustID.Text);
            cs.FNAME = tbxFirstName.Text;
            cs.LNAME = tbxLastName.Text;
            cs.SSNUM = tbxSSNumber.Text;
            cs.DOB = tbxDOB.Text;
            cs.ADD = tbxAddress.Text;
            cs.CITY = tbxCity.Text;
            cs.STATE = cmbstate.Text;
            cs.ZIP = tbxZip.Text;
            cs.PHONE = tbxPhone.Text;
            cs.ALTPHONE = tbxAltPhone.Text;
            cs.EMAIL = tbxEmail.Text;
            cs.EMP = tbxEmployer.Text;
            cs.DLNUMBER = tbxDL.Text;
            cs.DLCITY = tbxDLCity.Text;
            cs.DLSTATE = cmbdlState.Text;
            cs.EXPDATE = tbxEXP.Text;
            cs.CITI = tbxCitizen.Text;
            cs.MOTHER = tbxMother.Text;

            try
            {
                cs.CID = AppData.lastCust().CID + 1;
            }
            catch
            {
                cs.CID =  1;
            }

            AppData.saveToCustList(cs);


            MessageBox.Show("Data Saved" + Environment.NewLine + "Your New Customer Number is : " + cs.CID);

            AppData.saveToCustList(cs);
            //MessageBox.Show("Data Saved");

            {
                Close();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxCustID_TextChanged(object sender, EventArgs e)
        {
        
           
        
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewCust_Load(object sender, EventArgs e)
        {
            //tbxCustID.Text = Convert.ToString(AppData.lastCust().CID + 1);
        }
    }
}
