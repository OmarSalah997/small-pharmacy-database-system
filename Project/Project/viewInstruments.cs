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
    public partial class viewInstruments : Form
    {
        Controller c;
        int phcode;
        public viewInstruments(int code)
        {
            InitializeComponent();
            c = new Controller();
             phcode=code;
            dataGridView1.DataSource = c.Viewinstruments(phcode);
            dataGridView1.Refresh();
        }

        private void viewInstruments_Load(object sender, EventArgs e)
        {

        }
    }
}
