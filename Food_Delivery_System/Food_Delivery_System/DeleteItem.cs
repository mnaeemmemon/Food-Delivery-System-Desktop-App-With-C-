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
    public partial class DeleteItem : Form
    {

        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
       
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminPortal ad = new AdminPortal();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            if (item_id.Text == "")
            {
                MessageBox.Show("ID Required!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmddelete = new SqlCommand("Delete from dah_items where ID="+ item_id.Text +"", con);
                cmddelete.CommandType = CommandType.Text;
                cmddelete.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Item Deleted successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                AdminPortal ad = new AdminPortal();
                this.Hide();
                ad.ShowDialog();
                this.Close();
            }
        }

        private void itemname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
