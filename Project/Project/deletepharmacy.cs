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
    public partial class deletepharmacy : Form
    {
        Controller c;
        public deletepharmacy()
        {
            InitializeComponent();
            c = new Controller();
            comboBox1.DataSource = c.getpharmacynames();
            comboBox1.DisplayMember = "Name";
            comboBox1.Refresh();
        }

        private void deletepharmacy_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = c.deletepharmacy(comboBox1.Text);
            if (i == 0)
                MessageBox.Show("not deleted!!");
            else
            {
                MessageBox.Show("deleted successfuly");
                comboBox1.DataSource = c.getpharmacynames();
                comboBox1.Refresh();
            }

        }
    }
}
