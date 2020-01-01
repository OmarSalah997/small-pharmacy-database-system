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
    public partial class viewDrugs : Form
    {
        Controller c;
        int phcode;
        public viewDrugs(int code)
        {
            InitializeComponent();
            c = new Controller();
            phcode = code;
            dataGridView1.DataSource = c.Viewdrugs(phcode);
            dataGridView1.Refresh();

        }

        private void viewDrugs_Load(object sender, EventArgs e)
        {

        }
    }
}
