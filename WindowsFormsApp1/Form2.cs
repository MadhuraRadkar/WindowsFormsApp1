using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        List<string> dept = new List<string>()
        {
          "HR","Admin","Sales","Development","Testing","Marketing"
        };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            combDepartment.DataSource = dept;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bs = Convert.ToDouble(txtBasic_salary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs + hra + da + ta) - pf;

            txtHRA.Text = hra.ToString();
            txtTA.Text = ta.ToString();
            txtDA.Text = da.ToString();
            txtPF.Text = pf.ToString();
            txtGross.Text = gross.ToString();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = txtEmp_id.Text + "\n" + txtEmp_name.Text + "\n" + combDepartment.Text + "\n" + txtGross.Text;
            lblmsg.Text = msg;
        }
    }
}
