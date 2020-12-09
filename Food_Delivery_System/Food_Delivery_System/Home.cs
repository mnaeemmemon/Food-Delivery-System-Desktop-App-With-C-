using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userlog_Click(object sender, EventArgs e)
        {
            UserLogin u1 = new UserLogin();
            this.Hide();
            u1.ShowDialog();
            this.Close();
        }

        private void adminlog_Click(object sender, EventArgs e)
        {
            AdminLogin a1 = new AdminLogin();
            this.Hide();
            a1.ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
