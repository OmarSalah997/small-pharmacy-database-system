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
    public partial class Login : Form
    {
        Controller c1;
        public Login()
        {
            InitializeComponent();
            c1 = new Controller();
           
        }

        private void textBox2UserName_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int priv=c1.CheckPassword_Basic(textBox2UserName.Text,textBox2Password.Text);
            //manager =1|||employee=2|||client=3|||patient=4|||supplier=5|||donor=6|||applicant=7|||admin=10
            if (priv > 0)
            {
                if (priv == 1)
                {
                  int ssn=  c1.getssn(textBox2UserName.Text, textBox2Password.Text);
                    int code = c1.getPHcodeformanager(ssn);

                  PHARMACYForMang func = new PHARMACYForMang(ssn,code);

                 func. Show(this);
                    textBox2Password.Clear();
                    textBox2UserName.Clear();
                   
                }
                if (priv == 10)
                {
                    adminfuncs a = new adminfuncs();
                    a.Show(this);
                    textBox2Password.Clear();
                    textBox2UserName.Clear();

                }

            }
            else 
             MessageBox.Show("wrong username or password"); 

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
