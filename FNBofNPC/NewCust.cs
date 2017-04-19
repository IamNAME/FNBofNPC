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


namespace FNBOfNPC
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

       
    }
}
