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
    public partial class adddonor : Form
    {
        Controller c;

        public adddonor()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.adddonorbyadmin(textBox1name.Text, textBox2username.Text, textBox3pass.Text, textBox4phone.Text, textBox5email.Text, textBox6ID.Text);
            if (i == 0)
                MessageBox.Show("couldn`t add to system!!");
            else
            {
                i = c.insertintouserbasic(textBox2username.Text, textBox3pass.Text, 6);
                if (i == 0)
                    MessageBox.Show("user cant log to system!!");
                else
                {
                    MessageBox.Show("added successfully");
                    textBox1name.Clear();
                    textBox2username.Clear();
                    textBox3pass.Clear();
                    textBox4phone.Clear();
                    textBox5email.Clear();
                    textBox6ID.Clear();
                }
            }
        }
    }
}
