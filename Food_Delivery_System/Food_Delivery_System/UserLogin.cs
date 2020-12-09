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
    public partial class UserLogin : Form
    {

        public static string uname, umail, ucontact, uaddress, name, pass; 

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public UserLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {}

        private void login_btn_Click(object sender, EventArgs e)
        {
            Login();
        }


        public void Login()
        {
             name = user_name.Text;
             pass = user_pass.Text;

            if(name != "" && pass != "")
            {
                string query = "Select * from DAH_Users Where Name = '" + name + "' And Password = '" + pass + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if(dtUsers.Rows.Count == 1)
                {
                    uname = dtUsers.Rows[0]["Name"].ToString();
                    uaddress = dtUsers.Rows[0]["Address"].ToString();
                    ucontact = dtUsers.Rows[0]["Contact"].ToString();
                    umail = dtUsers.Rows[0]["Email"].ToString();

                    MessageBox.Show("Logged In Successfull...!", "Login Succesfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objDBAccess.closeConn();

                    UserPortal up = new UserPortal();
                    this.Hide();
                    up.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Occured, Try Again", "Signup Unsuccessful!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All feilds are required...!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void signup_btn_Click(object sender, EventArgs e)
        {
            UserSignup us = new UserSignup();
            this.Hide();
            us.ShowDialog();
            this.Close();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }
    }
}
