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
    public partial class PHARMACYForMang : Form
    {
        Controller Cph;
        int PHcode;
        int mgrssn;
        public PHARMACYForMang(int ssn,int code)
        {
            InitializeComponent();
            Cph = new Controller();
            PHcode = code;
            mgrssn = ssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewEmpForManager v = new ViewEmpForManager(PHcode);
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewDrugs v = new viewDrugs(PHcode);
            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            viewInstruments i = new viewInstruments(PHcode);
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewdonors d = new viewdonors(PHcode);
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addEmp a = new addEmp(PHcode);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEmp u = new UpdateEmp(PHcode);
            u.Show();
        }

        private void PHARMACYForMang_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactsupplier co = new contactsupplier(PHcode);
            co.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            viewAPPlicantsnames v = new viewAPPlicantsnames(PHcode);
            v.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DELETEeMPLOYEE d = new DELETEeMPLOYEE(PHcode);
            d.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            editpharmacy q = new editpharmacy(PHcode);
            q.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EDITMANAGERINFO i = new EDITMANAGERINFO(PHcode);
            i.Show();
        }
    }
}
