namespace Food_Delivery_System
{
    partial class UserSignup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSignup));
            this.Back_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.userpass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.useremail = new System.Windows.Forms.TextBox();
            this.user_email = new System.Windows.Forms.Label();
            this.usernum = new System.Windows.Forms.TextBox();
            this.useradd = new System.Windows.Forms.TextBox();
            this.user_num = new System.Windows.Forms.Label();
            this.user_add = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Peru;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Back_btn.Location = new System.Drawing.Point(31, 15);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(151, 49);
            this.Back_btn.TabIndex = 6;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(103, 0, 103, 0);
            this.label1.Size = new System.Drawing.Size(402, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Signup";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user_name.Location = new System.Drawing.Point(27, 111);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(75, 25);
            this.user_name.TabIndex = 9;
            this.user_name.Text = "Name :";
            // 
            // userpass
            // 
            this.userpass.AutoSize = true;
            this.userpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userpass.Location = new System.Drawing.Point(27, 292);
            this.userpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userpass.Name = "userpass";
            this.userpass.Size = new System.Drawing.Size(109, 25);
            this.userpass.TabIndex = 10;
            this.userpass.Text = "Password :";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(136, 111);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(210, 22);
            this.username.TabIndex = 11;
            // 
            // user_pass
            // 
            this.user_pass.Location = new System.Drawing.Point(136, 292);
            this.user_pass.Margin = new System.Windows.Forms.Padding(4);
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(209, 22);
            this.user_pass.TabIndex = 12;
            this.user_pass.UseSystemPasswordChar = true;
            this.user_pass.TextChanged += new System.EventHandler(this.user_pass_TextChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Black;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signup_btn.ForeColor = System.Drawing.Color.Snow;
            this.signup_btn.Location = new System.Drawing.Point(123, 346);
            this.signup_btn.Margin = new System.Windows.Forms.Padding(4);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(144, 39);
            this.signup_btn.TabIndex = 2;
            this.signup_btn.Text = "Signup";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.useremail);
            this.panel1.Controls.Add(this.user_email);
            this.panel1.Controls.Add(this.usernum);
            this.panel1.Controls.Add(this.useradd);
            this.panel1.Controls.Add(this.user_num);
            this.panel1.Controls.Add(this.user_add);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.user_pass);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.userpass);
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(420, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 430);
            this.panel1.TabIndex = 5;
            // 
            // useremail
            // 
            this.useremail.Location = new System.Drawing.Point(136, 254);
            this.useremail.Margin = new System.Windows.Forms.Padding(4);
            this.useremail.Name = "useremail";
            this.useremail.Size = new System.Drawing.Size(209, 22);
            this.useremail.TabIndex = 19;
            // 
            // user_email
            // 
            this.user_email.AutoSize = true;
            this.user_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user_email.Location = new System.Drawing.Point(27, 252);
            this.user_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_email.Name = "user_email";
            this.user_email.Size = new System.Drawing.Size(71, 25);
            this.user_email.TabIndex = 18;
            this.user_email.Text = "Email :";
            // 
            // usernum
            // 
            this.usernum.Location = new System.Drawing.Point(136, 212);
            this.usernum.Margin = new System.Windows.Forms.Padding(4);
            this.usernum.Name = "usernum";
            this.usernum.Size = new System.Drawing.Size(209, 22);
            this.usernum.TabIndex = 17;
            // 
            // useradd
            // 
            this.useradd.Location = new System.Drawing.Point(136, 156);
            this.useradd.Margin = new System.Windows.Forms.Padding(4);
            this.useradd.Multiline = true;
            this.useradd.Name = "useradd";
            this.useradd.Size = new System.Drawing.Size(209, 38);
            this.useradd.TabIndex = 16;
            this.useradd.TextChanged += new System.EventHandler(this.useradd_TextChanged);
            // 
            // user_num
            // 
            this.user_num.AutoSize = true;
            this.user_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user_num.Location = new System.Drawing.Point(27, 210);
            this.user_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_num.Name = "user_num";
            this.user_num.Size = new System.Drawing.Size(91, 25);
            this.user_num.TabIndex = 14;
            this.user_num.Text = "Contact :";
            // 
            // user_add
            // 
            this.user_add.AutoSize = true;
            this.user_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.user_add.Location = new System.Drawing.Point(27, 156);
            this.user_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(96, 25);
            this.user_add.TabIndex = 13;
            this.user_add.Text = "Address :";
            // 
            // UserSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSignup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label userpass;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernum;
        private System.Windows.Forms.TextBox useradd;
        private System.Windows.Forms.Label user_num;
        private System.Windows.Forms.Label user_add;
        private System.Windows.Forms.TextBox useremail;
        private System.Windows.Forms.Label user_email;
    }
}