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
    public partial class addnewsupplier : Form
    {
        Controller c;
        public addnewsupplier()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void addnewsupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.addnewsupplier(textBox1name.Text, textBox2phone.Text, textBox3email.Text, textBox4id.Text);
            if (i == 0)
                MessageBox.Show("not added to system!!!");
            else
            {
                MessageBox.Show(" added to system successfully");
                textBox1name.Clear();
                textBox2phone.Clear();
                textBox3email.Clear();
                textBox4id.Clear();

            }

        }
    }
}
