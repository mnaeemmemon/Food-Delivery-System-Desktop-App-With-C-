namespace Food_Delivery_System
{
    partial class Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pan = new System.Windows.Forms.Panel();
            this.idlab = new System.Windows.Forms.Label();
            this.cashlab = new System.Windows.Forms.Label();
            this.namelab = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.totallab = new System.Windows.Forms.Label();
            this.heading.SuspendLayout();
            this.pan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-36, 17);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(530, 0, 530, 0);
            this.label1.Size = new System.Drawing.Size(1293, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(546, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heading
            // 
            this.heading.BackColor = System.Drawing.Color.Black;
            this.heading.Controls.Add(this.label4);
            this.heading.Controls.Add(this.label3);
            this.heading.Controls.Add(this.label2);
            this.heading.Location = new System.Drawing.Point(296, 122);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(649, 50);
            this.heading.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(507, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Name";
            // 
            // pan
            // 
            this.pan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pan.Controls.Add(this.panel1);
            this.pan.Controls.Add(this.idlab);
            this.pan.Controls.Add(this.cashlab);
            this.pan.Controls.Add(this.namelab);
            this.pan.Controls.Add(this.label7);
            this.pan.Controls.Add(this.label6);
            this.pan.Controls.Add(this.label5);
            this.pan.Location = new System.Drawing.Point(296, 478);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(649, 103);
            this.pan.TabIndex = 6;
            // 
            // idlab
            // 
            this.idlab.AutoSize = true;
            this.idlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idlab.Location = new System.Drawing.Point(112, 65);
            this.idlab.Name = "idlab";
            this.idlab.Size = new System.Drawing.Size(58, 20);
            this.idlab.TabIndex = 13;
            this.idlab.Text = "Name ";
            // 
            // cashlab
            // 
            this.cashlab.AutoSize = true;
            this.cashlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cashlab.Location = new System.Drawing.Point(154, 42);
            this.cashlab.Name = "cashlab";
            this.cashlab.Size = new System.Drawing.Size(58, 20);
            this.cashlab.TabIndex = 12;
            this.cashlab.Text = "Name ";
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namelab.Location = new System.Drawing.Point(169, 19);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(58, 20);
            this.namelab.TabIndex = 11;
            this.namelab.Text = "Name ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(17, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Order ID : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(17, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cashier Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer Name : ";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(296, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 306);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.totallab);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(326, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 82);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.Location = new System.Drawing.Point(1, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 42);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Bill : ";
            // 
            // totallab
            // 
            this.totallab.AutoSize = true;
            this.totallab.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.totallab.Location = new System.Drawing.Point(179, 17);
            this.totallab.Name = "totallab";
            this.totallab.Size = new System.Drawing.Size(40, 42);
            this.totallab.TabIndex = 15;
            this.totallab.Text = "0";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Food_Delivery_System.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.heading.ResumeLayout(false);
            this.heading.PerformLayout();
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel heading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label idlab;
        private System.Windows.Forms.Label cashlab;
        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label totallab;
        private System.Windows.Forms.Label label8;
    }
}