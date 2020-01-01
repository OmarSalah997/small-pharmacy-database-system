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
    public partial class AddPharmacy : Form
    {
        Controller c;
        public AddPharmacy()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void AddPharmacy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.insertnewpharmacy(textBox1name.Text,textBox2code.Text,textBox3loc.Text,textBox4email.Text,textBox5open.Text,textBox6close.Text,textBox7rat.Text);
            if (i == 0)
                MessageBox.Show("NOT ADDED!!!PLEASE CHECK THE VALUES");
            else
            {
                MessageBox.Show("successfully added to the system");
                textBox1name.Clear();
                textBox2code.Clear();
                textBox3loc.Clear();
                textBox4email.Clear();
                textBox5open.Clear();
                textBox6close.Clear();
                textBox7rat.Clear();
            }

        }
    }
}
