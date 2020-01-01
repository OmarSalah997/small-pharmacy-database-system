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
   
    public partial class EDITMANAGERINFO : Form
    {
        Controller c;
        int phcode;
        string oldusername;
        string oldpassword;

        public EDITMANAGERINFO(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            textBox1username.Text = c.getmanagerusername(phcode);
            textBox2pass.Text = c.getmanagerpass(phcode);
            textBox3name.Text=c.getmanagername(phcode);
            textBox4phone.Text=c.getmanagerphone(phcode).ToString();
            textBox5addr.Text=c.getmanagerAddr(phcode);
            textBox6email.Text=c.getmanagerEmail(phcode);
            textBox7salary.Text=c.getmanagersalary(phcode).ToString();
            textBox8job.Text=c.getmanagerJob(phcode);
            textBox9age.Text=c.getmanagerAge(phcode).ToString();
            textBox10expyears.Text=c.getmanagerExpYears(phcode).ToString();
            oldusername= c.getmanagerusername(phcode);
            oldpassword= c.getmanagerpass(phcode);
        }

        private void EDITMANAGERINFO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.updatemanagerinfo(textBox3name.Text, textBox1username.Text, textBox2pass.Text, textBox4phone.Text, textBox5addr.Text, textBox6email.Text, textBox7salary.Text, textBox8job.Text, textBox9age.Text, textBox10expyears.Text, phcode);
            if (i == 0)
                MessageBox.Show("updating faild!!");
            else
            {
                i = c.updateuserbasic(textBox1username.Text, textBox2pass.Text, oldusername, oldpassword);
                if(i==0)
                    MessageBox.Show("due to the last update,the updated manager cannot enter the system,please contact your adminstrator");
                else
                    MessageBox.Show("update succeeded!مبروك");

            }
        }
    }
}
