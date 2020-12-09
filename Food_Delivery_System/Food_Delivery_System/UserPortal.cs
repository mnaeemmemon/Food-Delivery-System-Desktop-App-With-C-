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
    public partial class UserPortal : Form
    {

        public static string uid, uname, upass, uaddress, ucontact, umail;
        public static string[] it_names = new string[100];
        public static int[] it_quantity = new int[100];
        public static int[] it_price= new int[100];
        public static int c_count = 0;


        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        string id, name, price, quantity;
        int bc = 0;

        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess objDBAccess2 = new DBAccess();
        DataTable dtUsers2 = new DataTable();

        public UserPortal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserPortal_Load(object sender, EventArgs e)
        {
            int sizex=80, sizex2= 200, sizey=36, locx1 = 20, locx2 = 120, locx3=470, locy=20, fsize= 18, bly = 20;
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

                Button but = new Button();
                but = MakeButton(bly);

                panel2.Controls.Add(but);
                panel2.Controls.Add(l1);
                panel2.Controls.Add(l2);
                panel2.Controls.Add(l3);
                panel2.Controls.Add(p);

                plocy = plocy + 60;
                locy = locy + 60;
                bly = bly + 60;
            }



            string user_n = UserLogin.name;
            int j;

            con.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM DAH_Users", con);
            j = (int)cmd2.ExecuteScalar();
            con.Close();

            string query2 = "Select * from DAH_Users";
            objDBAccess2.readDatathroughAdapter(query2, dtUsers2);

            for (int k = 0; k < j; k++ )
            {
                 uid = dtUsers2.Rows[k]["ID"].ToString();
                 uname = dtUsers2.Rows[k]["Name"].ToString();
                 upass = dtUsers2.Rows[k]["Password"].ToString();
                 umail = dtUsers2.Rows[k]["Email"].ToString();
                 uaddress = dtUsers2.Rows[k]["Address"].ToString();
                 ucontact = dtUsers2.Rows[k]["Contact"].ToString();

                if (uname == user_n)
                {
                    us_name.Text = uname;
                    break;
                }
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

        Button MakeButton(int bly)
        {
            Button txtBox = new Button();
            txtBox.Name = bc.ToString();
            txtBox.Click += new EventHandler(button_Click);
            txtBox.Text = "Add";
            txtBox.Location = new System.Drawing.Point(560, bly);
            txtBox.Size = new System.Drawing.Size(100, 30);
            txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            txtBox.ForeColor = Color.White;
            txtBox.BackColor = Color.Black;

            bc++;
            return txtBox;
        }

        private void button_Click (object sender, EventArgs e)
        {
            Button button = sender as Button;

            quantity = InputBox("Quantity", "Enter Quantity:");

            if (quantity != "" && quantity != "0")
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM dah_items", con);
                int co = (int)cmd2.ExecuteScalar();
                con.Close();

                string query2 = "Select * from dah_items";
                objDBAccess2.readDatathroughAdapter(query2, dtUsers2);

                for (int k = 0; k < co; k++)
                {
                    id = dtUsers.Rows[k]["ID"].ToString();
                    name = dtUsers.Rows[k]["itemname"].ToString();
                    price = dtUsers.Rows[k]["itemprice"].ToString();

                    int a = Int16.Parse(button.Name);

                    if (k == a)
                    {
                        MessageBox.Show(quantity + " " + name + " Added In Your cart", "Item Added in Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

                int t1 = Int16.Parse(price);
                int t2 = Int16.Parse(quantity);
                bool found = false;

                for (int f = 0; f < c_count; f++)
                {
                    if (name == it_names[f])
                    {
                        it_quantity[f] = it_quantity[f] + t2;
                        found = true;
                        break;
                    }
                }
                if (found != true)
                {
                    it_names[c_count] = name;
                    it_price[c_count] = t1;
                    it_quantity[c_count] = t2;

                    c_count++;
                }
            }

        }

        public static string InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return textBox.Text;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            History h = new History();
            this.Hide();
            h.ShowDialog();
            this.Close();
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            UpdateID up = new UpdateID();
            this.Hide();
            up.ShowDialog();
            this.Close();
        }

        private void cartbtn_Click(object sender, EventArgs e)
        {
            
            Cart c = new Cart();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
