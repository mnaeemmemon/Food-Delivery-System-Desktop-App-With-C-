namespace Food_Delivery_System
{
    partial class DeleteItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteItem));
            this.item_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_id
            // 
            this.item_id.Location = new System.Drawing.Point(47, 127);
            this.item_id.Name = "item_id";
            this.item_id.Size = new System.Drawing.Size(165, 22);
            this.item_id.TabIndex = 6;
            this.item_id.TextChanged += new System.EventHandler(this.itemname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(77, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Item ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.item_id);
            this.panel2.Location = new System.Drawing.Point(473, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 208);
            this.panel2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(-48, 19);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.label4.Size = new System.Drawing.Size(391, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Delete Item";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.Color.Peru;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Back_btn.Location = new System.Drawing.Point(1106, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(113, 40);
            this.Back_btn.TabIndex = 8;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.BackColor = System.Drawing.Color.Black;
            this.dlt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dlt_btn.ForeColor = System.Drawing.Color.White;
            this.dlt_btn.Location = new System.Drawing.Point(540, 407);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(139, 36);
            this.dlt_btn.TabIndex = 12;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = false;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // DeleteItem
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeleteItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Item";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox item_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button dlt_btn;
    }
}