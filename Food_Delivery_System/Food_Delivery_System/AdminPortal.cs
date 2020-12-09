using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System
{
    public partial class AdminPortal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        string id, name, price, quantity; 

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public AdminPortal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

        }

        private void profilebtn_Click(object sender, EventArgs e)
        {        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            Additem up = new Additem();
            this.Hide();
            up.ShowDialog();
            this.Close();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            UpdateItem upd = new UpdateItem();
            this.Hide();
            upd.ShowDialog();
            this.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteItem ud = new DeleteItem();
            this.Hide();
            ud.ShowDialog();
            this.Close();

        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            int sizex=80, sizex2= 200, sizey=36, locx1 = 20, locx2 = 120, locx3=480, locx4=580, locy=20, fsize= 18;
            int psizex = 660,psizey = 52,plocx = 10,plocy = 10;
            int count;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dah_items", con);
            count = (int)cmd.ExecuteScalar();
            con.Close();

            string query = "Select * from dah_items";
            objDBAccess.readDatathroughAdapter(query, dtUsers);
            
            
            for (int i = 0; i < count; i++)
            {
                
                id = dtUsers.Rows[i]["ID"].ToString();
                name = dtUsers.Rows[i]["itemname"].ToString();
                price = dtUsers.Rows[i]["itemprice"].ToString();
                quantity = dtUsers.Rows[i]["itemquantity"].ToString();

                Panel p = new Panel();
                p = MakePanel(plocx, plocy, psizex, psizey);

                Label l1 = new Label();
                l1 = MakeLabel(id, sizex, sizey, locx1, locy, fsize);

                Label l2 = new Label();
                l2 = MakeLabel(name, sizex2, sizey, locx2, locy, fsize);

                Label l3 = new Label();
                l3 = MakeLabel(price, sizex, sizey, locx3, locy, fsize);

                Label l4 = new Label();
                l4 = MakeLabel(quantity, sizex, sizey, locx4, locy, fsize);

                panel2.Controls.Add(l1);
                panel2.Controls.Add(l2);
                panel2.Controls.Add(l3);
                panel2.Controls.Add(l4);
                panel2.Controls.Add(p);

                plocy = plocy + 60;
                locy = locy + 60;
            }
        }

        Label  MakeLabel(string text, int sizex, int sizey, int locx, int locy, int fsize) 
        {
            Label txtBox = new Label();
            txtBox.Text = text;
            txtBox.Location = new System.Drawing.Point(locx, locy);
            txtBox.Size = new System.Drawing.Size(sizex, sizey);
            txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", fsize);
            txtBox.ForeColor = Color.Black;
            txtBox.BackColor = Color.BurlyWood;

            return txtBox;
        }
        
        Panel MakePanel(int locx, int locy, int sizex, int sizey) 
        {
            Panel temp = new Panel();
            temp.BackColor = Color.BurlyWood;
            temp.Location = new System.Drawing.Point(locx, locy);
            temp.Size = new System.Drawing.Size(sizex, sizey);

            return temp;
        }

        private void i_name_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
