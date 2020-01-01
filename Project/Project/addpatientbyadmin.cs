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
    public partial class addpatientbyadmin : Form
    {
        Controller c;

        public addpatientbyadmin()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.addpatientbyadmin(textBox1name.Text, textBox2user.Text, textBox3pass.Text, textBox4phone.Text, textBox5add.Text, textBox6email.Text, textBox7ID.Text, textBox8ill.Text, textBox9phcode.Text);
            if (i == 0)
                MessageBox.Show("couldn`t add to system");
            else
            {
                i = c.insertintouserbasic(textBox2user.Text, textBox3pass.Text, 4);
                if (i == 0)
                    MessageBox.Show("user can`t log to system!");
                else
                {
                    MessageBox.Show("added successfully");
                    textBox1name.Clear();
                    textBox2user.Clear();
                    textBox3pass.Clear();
                    textBox4phone.Clear();
                    textBox5add.Clear();
                    textBox6email.Clear();
                    textBox7ID.Clear();
                    textBox8ill.Clear();
                    textBox9phcode.Clear();
                }

            }
        }
    }
}
