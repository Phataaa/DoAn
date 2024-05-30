namespace DoAn1
{
    partial class GUI_Taikhoan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvtk = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.vbtnlammoi = new DoAn1.VBButton();
            this.vbtnxoa = new DoAn1.VBButton();
            this.vbtnsua = new DoAn1.VBButton();
            this.vbtnthem = new DoAn1.VBButton();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.cbomaquyen = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 53);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvtk);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 333);
            this.panel1.TabIndex = 10;
            // 
            // dgvtk
            // 
            this.dgvtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtk.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtk.Location = new System.Drawing.Point(12, 6);
            this.dgvtk.Name = "dgvtk";
            this.dgvtk.RowHeadersWidth = 62;
            this.dgvtk.RowTemplate.Height = 28;
            this.dgvtk.Size = new System.Drawing.Size(1131, 324);
            this.dgvtk.TabIndex = 0;
            this.dgvtk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtk_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1155, 233);
            this.panel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbomaquyen);
            this.groupBox1.Controls.Add(this.cbomanv);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.ForeColor = System.Drawing.Color.Black;
            this.txtmk.Location = new System.Drawing.Point(638, 167);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(412, 37);
            this.txtmk.TabIndex = 13;
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.ForeColor = System.Drawing.Color.Black;
            this.txttk.Location = new System.Drawing.Point(95, 167);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(412, 37);
            this.txttk.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.vbtnlammoi);
            this.panel5.Controls.Add(this.vbtnxoa);
            this.panel5.Controls.Add(this.vbtnsua);
            this.panel5.Controls.Add(this.vbtnthem);
            this.panel5.Location = new System.Drawing.Point(0, 623);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 79);
            this.panel5.TabIndex = 12;
            // 
            // vbtnlammoi
            // 
            this.vbtnlammoi.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnlammoi.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnlammoi.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnlammoi.BorderRadius = 10;
            this.vbtnlammoi.BorderSize = 2;
            this.vbtnlammoi.FlatAppearance.BorderSize = 0;
            this.vbtnlammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnlammoi.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnlammoi.ForeColor = System.Drawing.Color.Black;
            this.vbtnlammoi.Location = new System.Drawing.Point(184, 12);
            this.vbtnlammoi.Name = "vbtnlammoi";
            this.vbtnlammoi.Size = new System.Drawing.Size(171, 57);
            this.vbtnlammoi.TabIndex = 7;
            this.vbtnlammoi.Text = "Làm mới";
            this.vbtnlammoi.TextColor = System.Drawing.Color.Black;
            this.vbtnlammoi.UseVisualStyleBackColor = false;
            this.vbtnlammoi.Click += new System.EventHandler(this.vbtnlammoi_Click);
            // 
            // vbtnxoa
            // 
            this.vbtnxoa.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnxoa.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnxoa.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnxoa.BorderRadius = 10;
            this.vbtnxoa.BorderSize = 2;
            this.vbtnxoa.FlatAppearance.BorderSize = 0;
            this.vbtnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnxoa.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnxoa.ForeColor = System.Drawing.Color.Black;
            this.vbtnxoa.Location = new System.Drawing.Point(800, 12);
            this.vbtnxoa.Name = "vbtnxoa";
            this.vbtnxoa.Size = new System.Drawing.Size(171, 57);
            this.vbtnxoa.TabIndex = 6;
            this.vbtnxoa.Text = "Xóa";
            this.vbtnxoa.TextColor = System.Drawing.Color.Black;
            this.vbtnxoa.UseVisualStyleBackColor = false;
            this.vbtnxoa.Click += new System.EventHandler(this.vbtnxoa_Click);
            // 
            // vbtnsua
            // 
            this.vbtnsua.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnsua.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnsua.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnsua.BorderRadius = 10;
            this.vbtnsua.BorderSize = 2;
            this.vbtnsua.FlatAppearance.BorderSize = 0;
            this.vbtnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnsua.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnsua.ForeColor = System.Drawing.Color.Black;
            this.vbtnsua.Location = new System.Drawing.Point(593, 12);
            this.vbtnsua.Name = "vbtnsua";
            this.vbtnsua.Size = new System.Drawing.Size(171, 57);
            this.vbtnsua.TabIndex = 5;
            this.vbtnsua.Text = "Sửa";
            this.vbtnsua.TextColor = System.Drawing.Color.Black;
            this.vbtnsua.UseVisualStyleBackColor = false;
            this.vbtnsua.Click += new System.EventHandler(this.vbtnsua_Click);
            // 
            // vbtnthem
            // 
            this.vbtnthem.BackColor = System.Drawing.Color.MistyRose;
            this.vbtnthem.BackgroundColor = System.Drawing.Color.MistyRose;
            this.vbtnthem.BorderColor = System.Drawing.Color.LightSalmon;
            this.vbtnthem.BorderRadius = 10;
            this.vbtnthem.BorderSize = 2;
            this.vbtnthem.FlatAppearance.BorderSize = 0;
            this.vbtnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbtnthem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbtnthem.ForeColor = System.Drawing.Color.Black;
            this.vbtnthem.Location = new System.Drawing.Point(386, 12);
            this.vbtnthem.Name = "vbtnthem";
            this.vbtnthem.Size = new System.Drawing.Size(171, 57);
            this.vbtnthem.TabIndex = 4;
            this.vbtnthem.Text = "Thêm";
            this.vbtnthem.TextColor = System.Drawing.Color.Black;
            this.vbtnthem.UseVisualStyleBackColor = false;
            this.vbtnthem.Click += new System.EventHandler(this.vbtnthem_Click);
            // 
            // cbomanv
            // 
            this.cbomanv.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(95, 78);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(412, 37);
            this.cbomanv.TabIndex = 14;
            // 
            // cbomaquyen
            // 
            this.cbomaquyen.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.cbomaquyen.FormattingEnabled = true;
            this.cbomaquyen.Location = new System.Drawing.Point(638, 78);
            this.cbomaquyen.Name = "cbomaquyen";
            this.cbomaquyen.Size = new System.Drawing.Size(412, 37);
            this.cbomaquyen.TabIndex = 15;
            // 
            // GUI_Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn1.Properties.Resources.background___form;
            this.ClientSize = new System.Drawing.Size(1155, 703);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "GUI_Taikhoan";
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.GUI_Taikhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvtk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private VBButton vbtnlammoi;
        private VBButton vbtnxoa;
        private VBButton vbtnsua;
        private VBButton vbtnthem;
        private System.Windows.Forms.ComboBox cbomaquyen;
        private System.Windows.Forms.ComboBox cbomanv;
    }
}