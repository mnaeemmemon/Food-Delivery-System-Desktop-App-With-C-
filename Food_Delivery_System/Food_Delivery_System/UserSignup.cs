using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System
{
    public partial class UserSignup : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public UserSignup()
        {
            InitializeComponent();
        }

        private void user_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (useradd.Text == "" || useremail.Text == "" || username.Text == "" || usernum.Text == "" || userpass.Text == "")
            {
                MessageBox.Show("All feilds are required...!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SignUp();   
            }
        }

        public void SignUp()
        { 

            string name = username.Text;
            string email = useremail.Text;
            string pass = user_pass.Text;
            string contact = usernum.Text;
            string address = useradd.Text;

            SqlCommand insertCommand = new SqlCommand("insert into DAH_Users(Name, Password, Email, Address, Contact) values(@name, @pass, @email, @address, @contact)");

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@pass", pass);
            insertCommand.Parameters.AddWithValue("@email", email);
            insertCommand.Parameters.AddWithValue("@address", address);
            insertCommand.Parameters.AddWithValue("@contact", contact);

            int row = objDBAccess.executeQuery(insertCommand);

            if(row == 1)
            {
                MessageBox.Show("Signed Up Successfully", "Signup Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserLogin us = new UserLogin();
                this.Hide();
                us.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error Occured, Try Again", "Signup Unsuccessfull!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return;
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            UserLogin us = new UserLogin();
            this.Hide();
            us.ShowDialog();
            this.Close();
        }

        private void useradd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
