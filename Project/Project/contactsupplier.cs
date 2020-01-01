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
    public partial class contactsupplier : Form
    {
        Controller c;
        int phcode;
        public contactsupplier(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            comboBox1supname.DataSource = c.getsupnames();
            comboBox1supname.DisplayMember = "Name";
            comboBox2drugname.DataSource = c.getdrugnames();
            comboBox2drugname.DisplayMember = "Name";
        }

        private void contactsupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.insertsupply(c.getsupIDbyName(comboBox1supname.Text), phcode, comboBox2drugname.Text, textBox1.Text);
            if (i == 0)
                MessageBox.Show("purchasing faild!!");
            else MessageBox.Show("purchasing succeeded");
        }
    }
}
