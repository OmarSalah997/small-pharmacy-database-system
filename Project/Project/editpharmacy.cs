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
    public partial class editpharmacy : Form
    {
        Controller c;
        int phcode;
        public editpharmacy(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            textBox1.Text = c.getpharmacyname(phcode);
            textBox2.Text = phcode.ToString();
            textBox3.Text = c.getpharmacyloc(phcode);
            textBox4.Text = c.getpharmacyEmail(phcode);
            textBox5.Text = c.getpharmacyopentime(phcode).ToString();
            textBox6.Text = c.getpharmacyCloseTime(phcode).ToString();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void editpharmacy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TimeSpan time1 = TimeSpan.Parse(textBox5.Text);
            if (time1 == null)
            {
                MessageBox.Show("wrong time format,right format is hh:mm:ss");
                return;
            }
            TimeSpan time2 = TimeSpan.Parse(textBox6.Text);
            if (time2 == null)
            {
                MessageBox.Show("wrong time format,right format is hh:mm:ss");
                return;
            }

            int i =   c.updatepharmacy(phcode,textBox1.Text,textBox3.Text,textBox4.Text,time1,time2);
            if (i == 0)
                MessageBox.Show("wrong insertion");
            else MessageBox.Show(" updated successfully!!*_*");

        }
    }
}
