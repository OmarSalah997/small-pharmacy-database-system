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
    public partial class UpdateEmp : Form
    {
        Controller c;
        int phcode;
        public UpdateEmp(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            comboBox1.DataSource = c.getEMPname(phcode);
            comboBox1.DisplayMember = "Name";
            comboBox2.DataSource = c.getEMPssn(phcode);
            comboBox2.DisplayMember = "SSN";

        }

        private void UpdateEmp_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //int i = c.checkNameSSn(comboBox1.Text, comboBox2.Text, phcode);
            //if (i == 0)
            //    MessageBox.Show("wrong !!name isn`t associated with ssn,try again ");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.checkNameSSn(comboBox1.Text, comboBox2.Text, phcode);
            if (i == 0)
                MessageBox.Show("wrong !!name isn`t associated with ssn,try again ");
            else {
                updateEMPinfo o = new updateEMPinfo(phcode, comboBox2.Text);
                    o.Show();
                 }

        }
    }
}
