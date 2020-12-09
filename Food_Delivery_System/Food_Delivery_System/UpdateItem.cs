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
    public partial class UpdateItem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminPortal ad = new AdminPortal();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            if (itemid.Text == "" || upd_q_item.Text == "" || new_price.Text == "")
            {
                MessageBox.Show("InComplete Information!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                SqlCommand cmdupdate;

                if (upd_q_item.Text == "*" && new_price.Text == "*")
                {
                    MessageBox.Show("Invalid Information!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (upd_q_item.Text == "*" && new_price.Text != "*")
                {
                    cmdupdate = new SqlCommand("Update dah_items SET itemprice = '" + new_price.Text + "' where ID= " + itemid.Text + "", con);
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Item Updated successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (upd_q_item.Text != "*" && new_price.Text == "*")
                {
                    cmdupdate = new SqlCommand("Update dah_items SET itemquantity = '" + upd_q_item.Text + "' where ID= " + itemid.Text + "", con);
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Item Updated successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (upd_q_item.Text != "*" && new_price.Text != "*")
                {
                    cmdupdate = new SqlCommand("Update dah_items SET itemquantity = '" + upd_q_item.Text + "', itemprice='" + new_price.Text + "' where ID= " + itemid.Text + "", con);
                    cmdupdate.CommandType = CommandType.Text;
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Item Updated successfully!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
                

                AdminPortal ad = new AdminPortal();
                this.Hide();
                ad.ShowDialog();
                this.Close();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
