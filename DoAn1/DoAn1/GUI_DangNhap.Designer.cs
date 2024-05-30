namespace DoAn1
{
    partial class GUI_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vbtndangky = new DoAn1.VBButton();
            this.vbtndn = new DoAn1.VBButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hide = new System.Windows.Forms.PictureBox();
            this.view = new System.Windows.Forms.PictureBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(151, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý cửa hàng đồ gia dụng nhà bếp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.vbtndangky);
            this.panel1.Controls.Add(this.vbtndn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(316, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 304);
            this.panel1.TabIndex = 2;
            // 
            // vbtndangky
            // 
            this.vbtndangky.BackColor = System.Drawing.SystemColors.Window;
            this.vbtndangky.BackgroundColor = System.Drawing.SystemColors.Window;
            this.vbtndangky.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vbtndangky.BorderRadius = 10;
            this.vbtndangky.BorderSize = 2;
            this.vbtndangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtndangky.FlatAppearance.BorderSize = 0;
            this.vbtndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtndangky.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtndangky.ForeColor = System.Drawing.Color.Red;
            this.vbtndangky.Location = new System.Drawing.Point(299, 224);
            this.vbtndangky.Name = "vbtndangky";
            this.vbtndangky.Size = new System.Drawing.Size(172, 57);
            this.vbtndangky.TabIndex = 2;
            this.vbtndangky.Text = "Đăng ký";
            this.vbtndangky.TextColor = System.Drawing.Color.Red;
            this.vbtndangky.UseVisualStyleBackColor = false;
            // 
            // vbtndn
            // 
            this.vbtndn.BackColor = System.Drawing.SystemColors.Window;
            this.vbtndn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.vbtndn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vbtndn.BorderRadius = 10;
            this.vbtndn.BorderSize = 2;
            this.vbtndn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtndn.FlatAppearance.BorderSize = 0;
            this.vbtndn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtndn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtndn.ForeColor = System.Drawing.Color.DarkGreen;
            this.vbtndn.Location = new System.Drawing.Point(83, 224);
            this.vbtndn.Name = "vbtndn";
            this.vbtndn.Size = new System.Drawing.Size(172, 57);
            this.vbtndn.TabIndex = 1;
            this.vbtndn.Text = "Đăng nhập";
            this.vbtndn.TextColor = System.Drawing.Color.DarkGreen;
            this.vbtndn.UseVisualStyleBackColor = false;
            this.vbtndn.Click += new System.EventHandler(this.vbtndn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hide);
            this.groupBox1.Controls.Add(this.view);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.SystemColors.Window;
            this.hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(417, 127);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(37, 30);
            this.hide.TabIndex = 5;
            this.hide.TabStop = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Window;
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Image = ((System.Drawing.Image)(resources.GetObject("view.Image")));
            this.view.Location = new System.Drawing.Point(417, 127);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(37, 30);
            this.view.TabIndex = 4;
            this.view.TabStop = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // txtmk
            // 
            this.txtmk.ForeColor = System.Drawing.Color.Gray;
            this.txtmk.Location = new System.Drawing.Point(105, 117);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(349, 40);
            this.txtmk.TabIndex = 3;
            // 
            // txttk
            // 
            this.txttk.ForeColor = System.Drawing.Color.Gray;
            this.txttk.Location = new System.Drawing.Point(105, 54);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(349, 40);
            this.txttk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(54, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 40);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\n";
            // 
            // GUI_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private VBButton vbtndn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private VBButton vbtndangky;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.PictureBox hide;
    }
}