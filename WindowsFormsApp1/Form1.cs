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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show("Login successful");
                  //To call form2 
                 // Form2 form2 = new Form2();
                //  form2.Show();
                //this.hide();
                MDIform obj = new MDIform();
                obj.Show();
                this.Hide(); // this refers to the login form.
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        
    }
}
