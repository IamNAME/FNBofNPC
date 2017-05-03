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

            Customer cust = new Customer();
            cust.CID = (Convert.ToInt32(tbxCustID.Text));
            cust.FNAME = tbxFirstName.Text;
            cust.LNAME = tbxLastName.Text;
            cust.SSNUM = tbxSSNumber.Text;
            cust.DOB = tbxDOB.Text;
            cust.ADD = tbxAddress.Text;
            cust.CITY = tbxCity.Text;
            cust.STATE = cmbstate.Text;
            cust.ZIP = tbxZip.Text;
            cust.PHONE = tbxPhone.Text;
            cust.ALTPHONE = tbxAltPhone.Text;
            cust.EMAIL = tbxEmail.Text;
            cust.EMP = tbxEmployer.Text;
            cust.DLNUMBER = tbxDL.Text;
            cust.DLCITY = tbxDLCity.Text;
            cust.DLSTATE = cmbdlState.Text;
            cust.EXPDATE = tbxEXP.Text;
            cust.CITI = tbxCitizen.Text;
            cust.MOTHER = tbxMother.Text;

            try
            {
                cust.CID = AppData.CustomerList.Last().CID + 1;
            }
            catch
            {
                cust.CID = 1;
            }

            tbxCustID.Text = Convert.ToString(cust.CID);
            AppData.saveToCustList(cust);
            MessageBox.Show("Data Saved");

            {
                Close();
            }
                //appdata.collect(cs)
                
            //}
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxCustID_TextChanged(object sender, EventArgs e)
        {
        
           
        
    }

        //    StreamWriter sw = new StreamWriter(@"C:\myfiles\mydata.txt");
        //    //FileStream fs = new FileStream(@"C:\myfiles\mydata.bin, 
        //    //    FileMode.CreatNew");
        //    //StreamWriter sw = new StreamWriter(fs);


        //    sw.WriteLine(tbxCustID.Text + "," +
        //       cs._fname tbxFirstName.Text + ","
        //        + tbxLastName.Text + "," 
        //        + tbxSSNumber.Text + ","
        //        + tbxDOB.Text + ","
        //        + tbxAddress.Text + ","
        //        + tbxCity.Text + ","
        //        + comboBox1.Text + ","
        //        + tbxZip.Text + ","
        //        + tbxPhone.Text + ","
        //        + tbxAltPhone.Text + ","
        //        + tbxEmail.Text + ","
        //        + tbxEmployer.Text + ","
        //        + tbxDL.Text + ","
        //        + tbxDLCity.Text + ","
        //        + comboBox2.Text + ","
        //        + tbxEXP.Text + ","
        //        + tbxCitizen.Text + ","
        //        + tbxMother.Text);
        //    sw.Close();
    }
}
