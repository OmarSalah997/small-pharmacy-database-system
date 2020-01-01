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
    public partial class viewdonors : Form
    {
        Controller c ;
        public viewdonors(int code)
        {
            InitializeComponent();
            c = new Controller();
            dataGridView1.DataSource = c.Viewdonors(code);
            dataGridView1.Refresh();
        }

        private void viewdonors_Load(object sender, EventArgs e)
        {

        }
    }
}
