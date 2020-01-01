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
    public partial class addinstrument : Form
    {
        Controller c;
        public addinstrument()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.addinstrumentbyadmin(textBox1name.Text,textBox2cat.Text,textBox3type.Text,textBox4id.Text);
            if (i == 0)
                MessageBox.Show("faild to add to the system");
            else
            {
                MessageBox.Show("added successfully!");
                textBox1name.Clear();
                textBox2cat.Clear();
                textBox3type.Clear();
                textBox4id.Clear();
                    
            }


        }
    }
}
