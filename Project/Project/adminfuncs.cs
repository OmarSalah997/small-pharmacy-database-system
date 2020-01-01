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
    public partial class adminfuncs : Form
    {
        public adminfuncs()
        {
            InitializeComponent();
        }

        private void button1ADDPHARMACY_Click(object sender, EventArgs e)
        {
            AddPharmacy a = new AddPharmacy();
            a.Show();
        }

        private void button2ADDMANAGER_Click(object sender, EventArgs e)
        {
            addmanager a = new addmanager();
            a.Show();
        }

        private void button4ADDADMIN_Click(object sender, EventArgs e)
        {
            addnewadmin a = new addnewadmin();
            a.Show();
        }

        private void button5ADDDRUG_Click(object sender, EventArgs e)
        {
            addnewdrug d = new addnewdrug();
            d.Show();
        }

        private void button6ADDSUPPLIER_Click(object sender, EventArgs e)
        {
            addnewsupplier s = new addnewsupplier();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletepharmacy d = new deletepharmacy();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deletemanager m = new deletemanager();
            m.Show();
        }

        private void button7ADDINSTRUMENT_Click(object sender, EventArgs e)
        {
            addinstrument d = new addinstrument();
            d.Show();
        }

        private void button9ADDDONOR_Click(object sender, EventArgs e)
        {
            adddonor a = new adddonor();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            addpatientbyadmin p = new addpatientbyadmin();
            p.Show();
        }
    }
}
