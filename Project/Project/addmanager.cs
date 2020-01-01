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
    public partial class addmanager : Form
    {
        Controller c;
        public addmanager()
        {
            InitializeComponent();
            c = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(textBox1code.Text);
            DataTable i = c.checkpharmacycodeexist(q);
            if (i == null)
                MessageBox.Show("pharmacy dont exist in the system!,please add pharmacy first");
            else { i = c.CheckPharmacyhasmanager(q);
                if (i != null)
                    MessageBox.Show("pharmacy already has a manager!,please delete existing manager first");
                else
                {
                    int g = c.insertnewmanager(textBox2name.Text, textBox3username.Text, textBox4pass.Text, textBox5phone.Text, textBox6addres.Text, textBox7email.Text, textBox8ssn.Text, textBox9sal.Text, textBox10job.Text, textBox11age.Text, textBox1code.Text, textBox12exp.Text);
                    if (g == 0)
                        MessageBox.Show("not added,please check values entered");
                    else
                    {
                        g = c.insertintouserbasic(textBox3username.Text, textBox4pass.Text, 1);
                        if (g == 0)
                            MessageBox.Show("cant log to system,check your code mate!!!!!!!");
                        else
                            MessageBox.Show("added successfully to system!");
                    }
                }
            }
        }
    }
}
