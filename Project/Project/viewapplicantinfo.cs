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
    
    public partial class viewapplicantinfo : Form
    {
        Controller c;
        public viewapplicantinfo(string name)
        {
            InitializeComponent();
            c = new Controller();
            textBox1name.Text = name;
            textBox1phone.Text = c.getApplicantphone(name).ToString();
            textBox2addr.Text = c.getApplicantaddr(name);
            textBox3e.Text = c.getApplicantEmail(name);
            textBox4ssn.Text = c.getApplicantSSN(name).ToString();
            textBox5job.Text = c.getApplicantjob(name);
            textBox6gen.Text = c.getApplicantGender(name);
            textBox7age.Text = c.getApplicantage(name).ToString();
            textBox8deg.Text = c.getApplicantDegree(name);
            textBox9col.Text = c.getApplicantCollege(name);

        }

        private void viewapplicantinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1username.Text == null || textBox2pass.Text == null || textBox1salary.Text == null)
                MessageBox.Show("please make sure to fill all fields ");
            else {
                    int i = c.InsertEmp(textBox1name.Text, textBox1username.Text, textBox2pass.Text, Convert.ToInt32(textBox1phone.Text), textBox2addr.Text, textBox3e.Text, Convert.ToInt32(textBox4ssn.Text), Convert.ToInt32(textBox1salary.Text), textBox5job.Text, Convert.ToInt32(textBox7age.Text), c.getApplicantPHCODE(textBox3e.Text));
                    if (i == 0)
                        MessageBox.Show("process faild!");
                    else
                        {   int s = c.insertintouserbasic(textBox1username.Text, textBox2pass.Text, 2);
                    if (s == 0)
                        MessageBox.Show("cant log in to the app!!!");
                   
                    else
                            s= c.deleteAPPlicant(textBox3e.Text);
                    if (s == 0)
                        MessageBox.Show("still applicant !");
                    else
                    MessageBox.Show("process succeeded!");
                        }
                 }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = c.deleteAPPlicant(textBox3e.Text);
            if (s == 0)
                MessageBox.Show("still applicant !");
            else
            {
                textBox1name.Clear();
                textBox1phone.Clear();
                textBox2addr.Clear();
                textBox3e.Clear();
                textBox4ssn.Clear();
                textBox5job.Clear();
                textBox6gen.Clear();
                textBox7age.Clear();
                textBox8deg.Clear();
                textBox9col.Clear();

                MessageBox.Show("request was refused successfuly!");
            }
        }
    }
}
