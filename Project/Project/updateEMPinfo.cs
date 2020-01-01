using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class updateEMPinfo : Form
    {
        Controller c;
        int phcode;
        int SSN;
        string olduser;
        string oldpass;
        public updateEMPinfo(int code,string ssn)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            
            SSN = Convert.ToInt32(ssn);
            textBox1.Text = c.getEmpnamebySSN(SSN);
            textBox2.Text = c.getEmpUSERNAMEbySSN(SSN);
            textBox3.Text = c.getEmpPassbySSN(SSN);
            textBox4.Text = c.getEmpPhonebySSN(SSN);
            textBox5.Text = c.getEmpAddrbySSN(SSN);
            textBox6.Text = c.getEmpEmailbySSN(SSN);
            textBox8.Text = c.getEmpSalarybySSN(SSN);
            textBox9.Text = c.getEmpJobbySSN(SSN);
            textBox10.Text = c.getEmpAgebySSN(SSN);
             olduser= c.getEmpUSERNAMEbySSN(SSN);
            oldpass= c.getEmpPassbySSN(SSN);
        }

        private void updateEMPinfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int i= c.UpdateEmployee(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text, textBox5.Text, textBox6.Text,textBox8.Text, textBox9.Text,SSN);
            if (i == 0)
                MessageBox.Show("wrong update!! please try different values");
            else
            {
                i = c.updateuserbasic(textBox1.Text, textBox2.Text, olduser, oldpass);
                if (i == 0)
                    MessageBox.Show("due to the last update,the updated employee cannot enter the system,please contact the adminstrator");
                else
                MessageBox.Show("update succeeded!مبروك");
            }
            }
        }
}
