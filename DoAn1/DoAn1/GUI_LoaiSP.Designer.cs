namespace DoAn1
{
    partial class GUI_LoaiSP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttenloai = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvloaisp = new System.Windows.Forms.DataGridView();
            this.vbtnxoa = new DoAn1.VBButton();
            this.vbtnsua = new DoAn1.VBButton();
            this.vbtnthem = new DoAn1.VBButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOẠI SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txttenloai);
            this.groupBox1.Controls.Add(this.txtmaloai);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 252);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txttenloai
            // 
            this.txttenloai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenloai.ForeColor = System.Drawing.Color.DarkGray;
            this.txttenloai.Location = new System.Drawing.Point(72, 126);
            this.txttenloai.Name = "txttenloai";
            this.txttenloai.Size = new System.Drawing.Size(397, 37);
            this.txttenloai.TabIndex = 1;
            this.txttenloai.Text = "Tên loại";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaloai.ForeColor = System.Drawing.Color.DarkGray;
            this.txtmaloai.Location = new System.Drawing.Point(72, 64);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(397, 37);
            this.txtmaloai.TabIndex = 0;
            this.txtmaloai.Text = "Mã loại";
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.ForeColor = System.Drawing.Color.DarkGray;
            this.txtmota.Location = new System.Drawing.Point(72, 187);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(397, 37);
            this.txtmota.TabIndex = 2;
            this.txtmota.Text = "Mô tả";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvloaisp);
            this.panel1.Location = new System.Drawing.Point(0, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 159);
            this.panel1.TabIndex = 3;
            // 
            // dgvloaisp
            // 
            this.dgvloaisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloaisp.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvloaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvloaisp.Location = new System.Drawing.Point(7, 6);
            this.dgvloaisp.Name = "dgvloaisp";
            this.dgvloaisp.RowHeadersWidth = 62;
            this.dgvloaisp.RowTemplate.Height = 28;
            this.dgvloaisp.Size = new System.Drawing.Size(538, 150);
            this.dgvloaisp.TabIndex = 0;
            this.dgvloaisp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaisp_CellClick);
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
            this.vbtnxoa.Location = new System.Drawing.Point(368, 521);
            this.vbtnxoa.Name = "vbtnxoa";
            this.vbtnxoa.Size = new System.Drawing.Size(137, 48);
            this.vbtnxoa.TabIndex = 10;
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
            this.vbtnsua.Location = new System.Drawing.Point(211, 521);
            this.vbtnsua.Name = "vbtnsua";
            this.vbtnsua.Size = new System.Drawing.Size(137, 48);
            this.vbtnsua.TabIndex = 9;
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
            this.vbtnthem.Location = new System.Drawing.Point(56, 521);
            this.vbtnthem.Name = "vbtnthem";
            this.vbtnthem.Size = new System.Drawing.Size(137, 48);
            this.vbtnthem.TabIndex = 8;
            this.vbtnthem.Text = "Thêm";
            this.vbtnthem.TextColor = System.Drawing.Color.Black;
            this.vbtnthem.UseVisualStyleBackColor = false;
            this.vbtnthem.Click += new System.EventHandler(this.vbtnthem_Click);
            // 
            // GUI_LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn1.Properties.Resources.background___form;
            this.ClientSize = new System.Drawing.Size(557, 581);
            this.Controls.Add(this.vbtnxoa);
            this.Controls.Add(this.vbtnsua);
            this.Controls.Add(this.vbtnthem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "GUI_LoaiSP";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.GUI_LoaiSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txttenloai;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvloaisp;
        private VBButton vbtnxoa;
        private VBButton vbtnsua;
        private VBButton vbtnthem;
    }
}