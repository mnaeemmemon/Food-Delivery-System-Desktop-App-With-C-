using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Food_Delivery_System
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=DAH;Integrated Security =True");
        string name;
        int price, quantity, r2, total;
        string[] cashier = new string[5];

        MailMessage mail = new MailMessage();
        NetworkCredential login;
        SmtpClient SmtpServer;
     
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            int sizex = 200, sizex2 = 80, sizey = 36, locx1 = 30, locx2 = 300, locx3 = 385, locy = 14, fsize = 18, bly = 20;
            int psizex = 470, psizey = 40, plocx = 10, plocy = 10;

            cashier[0] = "Naeem"; cashier[1] = "Irhaam"; cashier[2] = "Human"; cashier[3] = "Kishwer"; cashier[4] = "Jameel";

            for (int i = 0; i < UserPortal.c_count; i++)
            {
                name = UserPortal.it_names[i];
                price = UserPortal.it_price[i] * UserPortal.it_quantity[i];
                quantity = UserPortal.it_quantity[i];

                Panel p = new Panel();
                p = MakePanel(plocx, plocy, psizex, psizey);

                Label l1 = new Label();
                l1 = MakeLabel(name, sizex, sizey, locx1, locy, fsize);

                string qua = quantity.ToString();
                string pri = price.ToString();

                Label l2 = new Label();
                l2 = MakeLabel(qua, sizex2, sizey, locx2, locy, fsize);

                Label l3 = new Label();
                l3 = MakeLabel(pri, sizex2, sizey, locx3, locy, fsize);

                panel2.Controls.Add(l1);
                panel2.Controls.Add(l2);
                panel2.Controls.Add(l3);
                panel2.Controls.Add(p);

                plocy = plocy + 50;
                locy = locy + 50;
                bly = bly + 50;       

            }

            Random r = new Random();
            int r1 = r.Next(5);
            r2 = r.Next(1000);

            cashlab.Text = cashier[r1];
            idlab.Text = r2.ToString();
            namelab.Text = UserLogin.name;

            total = 0 ;
            for (int h = 0; h < UserPortal.c_count; h++)
            { 
                int a = UserPortal.it_price[h] * UserPortal.it_quantity[h];
                total = total + a;
            }

            totallab.Text = total.ToString();

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string allitems = "1) " + UserPortal.it_quantity[0].ToString() + " --> " + UserPortal.it_names[0] + "\n";

            for (int y = 1; y < UserPortal.c_count; y++)
            {
                allitems = allitems + (y+1) + ") " + UserPortal.it_quantity[y].ToString() + " --> " + UserPortal.it_names[y] + "\n";
            }


            login = new NetworkCredential("your email", "your pass");
            SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = login;
            SmtpServer.EnableSsl = true;

            mail.From = new MailAddress("your email");
            mail.To.Add(UserPortal.umail);
            mail.Subject = "DAH Order Confiramtion";
            mail.Body = "Your order is successfully placed at Dine At Home and will be processed further.\n\nOrder Id: " + r2 + "\nOrder will be delievered at: " +UserPortal.uaddress+ "\nContact No: " +UserPortal.ucontact+ "\n\n#) Your Order\n\n" + allitems +"\nTotal Amount: " + total + "\n\nTHANKYOU!";

            SmtpServer.Send(mail);

            MessageBox.Show("Thankyou for ordering with DAH. You will recieve a confirmation email soon.", "Dine At Home", MessageBoxButtons.OK, MessageBoxIcon.Information);

            for (int a = 0; a < UserPortal.c_count; a++)
            {
                UserPortal.it_quantity[a] = 0;
                UserPortal.it_price[a] = 0;
                UserPortal.it_names[a] = " ";
            }
            UserPortal.c_count = 0;

            UserPortal up = new UserPortal();
            this.Hide();
            up.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
