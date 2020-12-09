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
    public partial class UpdateID : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        string uid, uname, uaddress, upass, umail, ucontact;


        public UpdateID()
        {
            InitializeComponent();
        }

        private void UpdateID_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM DAH_Users", con);
            int j = (int)cmd2.ExecuteScalar();
            con.Close();

            string user_n = UserLogin.name;

            string query = "Select * from DAH_Users";
            objDBAccess.readDatathroughAdapter(query, dtUsers);

            for (int k = 0; k < j; k++)
            {
                uid = dtUsers.Rows[k]["ID"].ToString();
                uname = dtUsers.Rows[k]["Name"].ToString();
                upass = dtUsers.Rows[k]["Password"].ToString();
                umail = dtUsers.Rows[k]["Email"].ToString();
                uaddress = dtUsers.Rows[k]["Address"].ToString();
                ucontact = dtUsers.Rows[k]["Contact"].ToString();

                if (uname == user_n)
                {
                    this.upadd.Text = uaddress;
                    this.upcontact.Text = ucontact;
                    this.uppass.Text = upass;
                    this.upmail.Text = umail;
                    this.upname.Text = uname;

                    break;
                }
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            uaddress = this.upadd.Text;
            ucontact = this.upcontact.Text;
            upass = this.uppass.Text;
            umail = this.upmail.Text;
            uname = this.upname.Text;

            con.Open();
            SqlCommand cmdupdate = new SqlCommand("Update DAH_Users SET Name = '" + uname + "', Password = '" + upass + "' , Email = '" + umail + "', Address = '" + uaddress + "', Contact = '" + ucontact + "' where ID= " + uid + "", con);
            cmdupdate.CommandType = CommandType.Text;
            cmdupdate.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("ID Updated successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UserPortal up = new UserPortal();
            this.Hide();
            up.ShowDialog();
            this.Close();
        }
    }
}
