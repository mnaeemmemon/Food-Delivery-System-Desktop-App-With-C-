using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Food_Delivery_System
{
    public partial class History : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        string id, c_name, c_id, i_name, i_price, i_quantity;
        int bc = 0, i, bc2 = 0;

        public History()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void History_Load(object sender, EventArgs e)
        {
            int sizex = 80, sizex2 = 200, sizey = 36, locx1 = 30, locx2 = 550, locx3 = 700, locy = 20, fsize = 18, bly = 14, bly2 = 36;
            int psizex = 900, psizey = 52, plocx = 10, plocy = 10;
            int count;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dah_orders", con);
            count = (int)cmd.ExecuteScalar();
            con.Close();

            string query = "Select * from dah_orders";
            objDBAccess.readDatathroughAdapter(query, dtUsers);


            for (int k = 0; k < count; k++)
            {
                id = dtUsers.Rows[k]["ID"].ToString();
                c_name = dtUsers.Rows[k]["customer_name"].ToString();
                c_id = dtUsers.Rows[k]["customer_id"].ToString();
                i_name = dtUsers.Rows[k]["i_name"].ToString();
                i_price = dtUsers.Rows[k]["i_price"].ToString();
                i_quantity = dtUsers.Rows[k]["i_quantity"].ToString();

                if (c_id == UserPortal.uid && c_name == UserPortal.uname)
                {
                    Panel p = new Panel();
                    p = MakePanel(plocx, plocy, psizex, psizey);

                    Label l1 = new Label();
                    l1 = MakeLabel(i_name, sizex2, sizey, locx1, locy, fsize);

                    Label l2 = new Label();
                    l2 = MakeLabel(i_price, sizex, sizey, locx2, locy, fsize);

                    Label l3 = new Label();
                    l3 = MakeLabel(i_quantity, sizex, sizey, locx3, locy, fsize);


                    panel2.Controls.Add(l1);
                    panel2.Controls.Add(l2);
                    panel2.Controls.Add(l3);
                    panel2.Controls.Add(p);

                    plocy = plocy + 60;
                    locy = locy + 60;
                    bly = bly + 60;
                    bly2 = bly2 + 60;
                }
            }
        }

        Label MakeLabel(string text, int sizex, int sizey, int locx, int locy, int fsize)
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

        private void bckbtn_Click(object sender, EventArgs e)
        {
            UserPortal up = new UserPortal();
            this.Hide();
            up.ShowDialog();
            this.Close();
        }
    }
}
