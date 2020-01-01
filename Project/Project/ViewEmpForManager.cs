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
    public partial class ViewEmpForManager : Form
    {
        Controller c;
        int PHcode;
        public ViewEmpForManager(int code)
        {
            InitializeComponent();
            c = new Controller();
            PHcode = code;
            DataTable t  = c.ViewEmployees(PHcode);
            dataGridView1.DataSource = t;
            dataGridView1.Refresh();
            
        }

        private void ViewEmpForManager_Load(object sender, EventArgs e)
        {

        }
    }
}
