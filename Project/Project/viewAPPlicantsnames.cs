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
    public partial class viewAPPlicantsnames : Form
    {
        Controller c;
        int phcode;
        public viewAPPlicantsnames(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            comboBox1.DataSource = c.viewAPPlicantnames(phcode);
            comboBox1.DisplayMember = "Name";
          //  comboBox1.Refresh();
        }    private void viewAPPlicants_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewapplicantinfo i = new viewapplicantinfo(comboBox1.Text);
            i.Show();
        }
    }
}
