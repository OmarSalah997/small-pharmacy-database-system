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
    public partial class addnewdrug : Form
    {
        Controller c;

        public addnewdrug()
        {
            InitializeComponent();
            c = new Controller();

        }

        private void addnewdrug_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.addnewdrug(textBox1name.Text, textBox2type.Text, textBox3price.Text, textBox4exp.Text);
            if (i == 0)
                MessageBox.Show("not added to system!!!");
            else
            {
                MessageBox.Show(" added to system successfully");
                textBox1name.Clear();
                textBox2type.Clear();
                textBox3price.Clear();
                textBox4exp.Clear();

            }
        }
    }
}
