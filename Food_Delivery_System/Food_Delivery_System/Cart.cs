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
    public partial class Cart : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        string id, name, price, quantity;
        int bc = 0, i, bc2 = 0;

        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            int sizex = 80, sizex2 = 200, sizey = 36, locx1 = 30, locx2 = 550, locx3 = 700, locy = 20, fsize = 18, bly = 14, bly2 = 36;
            int psizex = 900, psizey = 52, plocx = 10, plocy = 10;
            int count;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM dah_items", con);
            count = (int)cmd.ExecuteScalar();
            con.Close();

            string query = "Select * from dah_items";
            objDBAccess.readDatathroughAdapter(query, dtUsers);


            for (i = 0; i < UserPortal.c_count; i++)
            {
                name = UserPortal.it_names[i];
                price = UserPortal.it_price[i].ToString();
                quantity = UserPortal.it_quantity[i].ToString();

                Panel p = new Panel();
                p = MakePanel(plocx, plocy, psizex, psizey);

                Label l1 = new Label();
                l1 = MakeLabel(name, sizex2, sizey, locx1, locy, fsize);

                Label l2 = new Label();
                l2 = MakeLabel(price, sizex, sizey, locx2, locy, fsize);

                Label l3 = new Label();
                l3 = MakeLabel(quantity, sizex, sizey, locx3, locy, fsize);


                Button but = new Button();
                but = MakeButton(bly);

                Button but2 = new Button();
                but2 = MakeButton2(bly2);

                panel2.Controls.Add(but);
                panel2.Controls.Add(but2);
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

        Button MakeButton(int bly)
        {
            Button txtBox = new Button();
            txtBox.Name = bc.ToString();
            txtBox.Click += new EventHandler(button_Click);
            txtBox.Text = "Remove";
            txtBox.Location = new System.Drawing.Point(800, bly);
            txtBox.Size = new System.Drawing.Size(70, 22);
            txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8);
            txtBox.ForeColor = Color.White;
            txtBox.BackColor = Color.Black;

            bc++;
            return txtBox;
        }

        Button MakeButton2(int bly2)
        {
            Button txtBox = new Button();
            txtBox.Name = bc2.ToString();
            txtBox.Click += new EventHandler(button_Click2);
            txtBox.Text = "Change Quantity";
            txtBox.Location = new System.Drawing.Point(775, bly2);
            txtBox.Size = new System.Drawing.Size(120, 22);
            txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8);
            txtBox.ForeColor = Color.White;
            txtBox.BackColor = Color.Black;

            bc2++;
            return txtBox;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int loc = Int16.Parse(button.Name);
            for (int j = loc; j < UserPortal.c_count - 1; j++)
            {
                UserPortal.it_names[j] = UserPortal.it_names[j + 1];
                UserPortal.it_price[j] = UserPortal.it_price[j + 1];
                UserPortal.it_quantity[j] = UserPortal.it_quantity[j + 1];
            }
            UserPortal.c_count--;

            Cart c = new Cart();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void button_Click2(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int num = Int16.Parse(button.Name);

            string quan = InputBox("Quantity", "New Quantity");
            int q = Int16.Parse(quan);
            UserPortal.it_quantity[num] = q;

            Cart c = new Cart();
            this.Hide();
            c.ShowDialog();
            this.Close();
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


        private void choutbtn_Click(object sender, EventArgs e)
        {
            if (UserPortal.c_count != 0)
            {
                con.Open();

                for (int h = 0; h < UserPortal.c_count; h++)
                {
                    SqlCommand cmdinsert = new SqlCommand("Insert into dah_orders values ( '" + UserPortal.uname + "' , '" + UserPortal.uid + "'  , '" + UserPortal.it_names[h] + "', '" + UserPortal.it_quantity[h] + "', '" + UserPortal.it_price[h] + "')", con);
                    cmdinsert.CommandType = CommandType.Text;
                    cmdinsert.ExecuteNonQuery();
                }

                con.Close();

                Bill b = new Bill();
                this.Hide();
                b.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your cart is empty!\nEnter atleast one item to proceed", "Not valid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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
