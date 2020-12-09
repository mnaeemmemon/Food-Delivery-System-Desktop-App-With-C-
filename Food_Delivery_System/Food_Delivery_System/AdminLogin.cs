using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {}
        private void admin_id_TextChanged(object sender, EventArgs e)
        {}

        private void login_btn_Click(object sender, EventArgs e)
        {
            login();
        }


        public void login()
        {
            string name = admin_name.Text;
            string pass = admin_pass.Text;

            if (name == "manager" && pass == "guru")
            {
                AdminPortal ap = new AdminPortal();
                this.Hide();
                ap.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Name Or Password is incorrect...!", "Login UnSuccessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void admin_pass_TextChanged(object sender, EventArgs e)
        {}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
