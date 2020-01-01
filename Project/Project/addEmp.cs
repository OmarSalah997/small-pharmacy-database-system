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
    
    public partial class addEmp : Form
    {
        Controller c;
        int phcode;
        public addEmp(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.InsertEmp(textBox1.Text,textBox2.Text,textBox3.Text,Convert.ToInt32(textBox4.Text),textBox5.Text,textBox6.Text,Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text),textBox9.Text, Convert.ToInt32(textBox10.Text),phcode);
            if (i == 0)
                MessageBox.Show("wrong insertion!! please try different values");
            else
            {
                int h = c.insertintouserbasic(textBox2.Text, textBox3.Text, 2);
                if(h==0)
                    MessageBox.Show("cont log to system");
                else { 
                MessageBox.Show("insertion succeeded!مبروك");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                     }

            }
        }
    }
}
