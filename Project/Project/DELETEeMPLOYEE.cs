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
    public partial class DELETEeMPLOYEE : Form
    {
        Controller c;
        int phcode;
        public DELETEeMPLOYEE(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            comboBox1.DataSource = c.getEMPname(code);
            comboBox1.DisplayMember = "Name";
            comboBox2.DataSource = c.getEMPemails(code);
            comboBox2.DisplayMember = "Email";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = c.getEmpUsernamebyemail(comboBox2.Text);
            string p = c.getEmpPassbyemail(comboBox2.Text);
         int i=   c.deleteEmployee(comboBox1.Text,comboBox2.Text,phcode);
            if(i==0)
               { MessageBox.Show("process faild!"); }

            else {
                i = c.deletefromuserbasic(u, p);
                if (i == 0)
                { MessageBox.Show("process faild!,contact your admin"); }
                else
                {
                    MessageBox.Show("process succeeded!");
                    comboBox1.DataSource = c.getEMPname(phcode);
                    comboBox1.DisplayMember = "Name";
                    comboBox2.DataSource = c.getEMPemails(phcode);
                    comboBox2.DisplayMember = "Email";
                }
                   
            }
        }
    }
}
