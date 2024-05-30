namespace DoAn1
{
    partial class GUI_SanPham
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
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxuatxu = new System.Windows.Forms.ComboBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtkichthuoc = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbomancc = new System.Windows.Forms.ComboBox();
            this.cbomaloai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.vbtnlammoi = new DoAn1.VBButton();
            this.vbtnxoa = new DoAn1.VBButton();
            this.vbtnsua = new DoAn1.VBButton();
            this.vbtnthem = new DoAn1.VBButton();
            this.Export = new DoAn1.VBButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvSP);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 205);
            this.panel2.TabIndex = 11;
            // 
            // dgvSP
            // 
            this.dgvSP.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.Location = new System.Drawing.Point(11, 6);
            this.dgvSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.RowHeadersWidth = 62;
            this.dgvSP.RowTemplate.Height = 28;
            this.dgvSP.Size = new System.Drawing.Size(1005, 196);
            this.dgvSP.TabIndex = 0;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 36);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã SP";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboxuatxu);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.txtkichthuoc);
            this.groupBox1.Controls.Add(this.txttensp);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbomancc);
            this.groupBox1.Controls.Add(this.cbomaloai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1004, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cboxuatxu
            // 
            this.cboxuatxu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxuatxu.FormattingEnabled = true;
            this.cboxuatxu.Items.AddRange(new object[] {
            "Việt Nam",
            "Thổ Nhỹ Kỳ",
            "Đức",
            "Trung Quốc",
            "Thái Lan",
            "Malaysia"});
            this.cboxuatxu.Location = new System.Drawing.Point(702, 122);
            this.cboxuatxu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxuatxu.Name = "cboxuatxu";
            this.cboxuatxu.Size = new System.Drawing.Size(256, 33);
            this.cboxuatxu.TabIndex = 31;
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(704, 188);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(262, 32);
            this.txtmota.TabIndex = 30;
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(371, 189);
            this.txtsl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(262, 32);
            this.txtsl.TabIndex = 29;
            // 
            // txtgia
            // 
            this.txtgia.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgia.Location = new System.Drawing.Point(40, 189);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(262, 32);
            this.txtgia.TabIndex = 28;
            // 
            // txtkichthuoc
            // 
            this.txtkichthuoc.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkichthuoc.Location = new System.Drawing.Point(371, 123);
            this.txtkichthuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkichthuoc.Name = "txtkichthuoc";
            this.txtkichthuoc.Size = new System.Drawing.Size(262, 32);
            this.txtkichthuoc.TabIndex = 26;
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(371, 54);
            this.txttensp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(262, 32);
            this.txttensp.TabIndex = 25;
            // 
            // txtmasp
            // 
            this.txtmasp.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasp.Location = new System.Drawing.Point(40, 54);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(262, 32);
            this.txtmasp.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(700, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(366, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(700, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Xuất xứ";
            // 
            // cbomancc
            // 
            this.cbomancc.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomancc.FormattingEnabled = true;
            this.cbomancc.Location = new System.Drawing.Point(40, 123);
            this.cbomancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomancc.Name = "cbomancc";
            this.cbomancc.Size = new System.Drawing.Size(262, 33);
            this.cbomancc.TabIndex = 16;
            // 
            // cbomaloai
            // 
            this.cbomaloai.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomaloai.FormattingEnabled = true;
            this.cbomaloai.Location = new System.Drawing.Point(704, 55);
            this.cbomaloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbomaloai.Name = "cbomaloai";
            this.cbomaloai.Size = new System.Drawing.Size(256, 33);
            this.cbomaloai.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(700, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(366, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kích thước";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.txttimkiem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 242);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1026, 38);
            this.panel4.TabIndex = 13;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.ForeColor = System.Drawing.Color.Gray;
            this.txttimkiem.Location = new System.Drawing.Point(537, 3);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(480, 32);
            this.txttimkiem.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.Export);
            this.panel5.Controls.Add(this.vbtnlammoi);
            this.panel5.Controls.Add(this.vbtnxoa);
            this.panel5.Controls.Add(this.vbtnsua);
            this.panel5.Controls.Add(this.vbtnthem);
            this.panel5.Location = new System.Drawing.Point(0, 498);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1026, 65);
            this.panel5.TabIndex = 14;
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
            this.vbtnlammoi.Location = new System.Drawing.Point(125, 10);
            this.vbtnlammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbtnlammoi.Name = "vbtnlammoi";
            this.vbtnlammoi.Size = new System.Drawing.Size(152, 46);
            this.vbtnlammoi.TabIndex = 3;
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
            this.vbtnxoa.Location = new System.Drawing.Point(664, 10);
            this.vbtnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbtnxoa.Name = "vbtnxoa";
            this.vbtnxoa.Size = new System.Drawing.Size(152, 46);
            this.vbtnxoa.TabIndex = 2;
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
            this.vbtnsua.Location = new System.Drawing.Point(478, 10);
            this.vbtnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbtnsua.Name = "vbtnsua";
            this.vbtnsua.Size = new System.Drawing.Size(152, 46);
            this.vbtnsua.TabIndex = 1;
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
            this.vbtnthem.Location = new System.Drawing.Point(302, 10);
            this.vbtnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbtnthem.Name = "vbtnthem";
            this.vbtnthem.Size = new System.Drawing.Size(152, 46);
            this.vbtnthem.TabIndex = 0;
            this.vbtnthem.Text = "Thêm";
            this.vbtnthem.TextColor = System.Drawing.Color.Black;
            this.vbtnthem.UseVisualStyleBackColor = false;
            this.vbtnthem.Click += new System.EventHandler(this.vbtnthem_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.MistyRose;
            this.Export.BackgroundColor = System.Drawing.Color.MistyRose;
            this.Export.BorderColor = System.Drawing.Color.LightSalmon;
            this.Export.BorderRadius = 10;
            this.Export.BorderSize = 2;
            this.Export.FlatAppearance.BorderSize = 0;
            this.Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.ForeColor = System.Drawing.Color.Black;
            this.Export.Location = new System.Drawing.Point(838, 10);
            this.Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(152, 46);
            this.Export.TabIndex = 4;
            this.Export.Text = "In";
            this.Export.TextColor = System.Drawing.Color.Black;
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // GUI_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAn1.Properties.Resources.background___form;
            this.ClientSize = new System.Drawing.Size(1027, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GUI_SanPham";
            this.Load += new System.EventHandler(this.GUI_SanPham_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label2;
        private VBButton vbtnlammoi;
        private VBButton vbtnxoa;
        private VBButton vbtnsua;
        private System.Windows.Forms.Panel panel5;
        private VBButton vbtnthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbomaloai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbomancc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtkichthuoc;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.ComboBox cboxuatxu;
        private VBButton Export;
    }
}