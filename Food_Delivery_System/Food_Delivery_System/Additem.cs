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
    public partial class Additem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        public Additem()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminPortal ad = new AdminPortal();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (it_id.Text == "" || name.Text == "" || item_qua.Text == "" || itemp.Text == "")
            {
                MessageBox.Show("InComplete Information!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmdinsert = new SqlCommand("Insert into dah_items values ( '" + it_id.Text + "' , '" + name.Text + "'  , '" + itemp.Text + "', '" + item_qua.Text + "')", con);
                cmdinsert.CommandType = CommandType.Text;
                cmdinsert.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Item Added successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminPortal ad = new AdminPortal();
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
        }
    }
}
