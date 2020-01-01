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
    public partial class addnewadmin : Form
    {
        Controller c;

        public addnewadmin()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void addnewadmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.addnewadmin(textBox1user.Text, textBox2pass.Text);
            if (i == 0)
                MessageBox.Show("not added!!!");
            else
                MessageBox.Show(" added successfully");

        }
    }
}
