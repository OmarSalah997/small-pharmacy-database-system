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
    public partial class deletemanager : Form
    {
        Controller c;
        public deletemanager()
        {
            InitializeComponent();
            c = new Controller();
            comboBox1.DataSource = c.getpharmacynames();
            comboBox1.DisplayMember = "Name";
            comboBox1.Refresh();

        }

        private void deletemanager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {      int code = c.getpharmacycodebyname(comboBox1.Text);
            string name = c.getmanagerusername(code);
                    string p = c.getmanagerpass(code);
       
            DataTable i = c.CheckPharmacyhasmanager(code);
            if (i == null)
                MessageBox.Show("pharmacy already has no manager");
            else
            {
                int h = c.deletemanager(code);
                if (h == 0)
                    MessageBox.Show("not deleted!!");
                else
                {
                   
                    h = c.deletefromuserbasic(name, p);
                    if(h==0)
                        MessageBox.Show("not deleted from user basic!!,contact your admin");
                    else
                    { 
                    MessageBox.Show("deleted successfully");
                        comboBox1.Refresh();

                    }
                }
            }
        }
    }
}
