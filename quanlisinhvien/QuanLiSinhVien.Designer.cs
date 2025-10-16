namespace quanlisinhvien
{
    partial class QuanLiSinhVien
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
            this.grpthongtinsinhvien = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.lbllop = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtnamsinh = new System.Windows.Forms.TextBox();
            this.lblnamsinh = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.txttensinhvien = new System.Windows.Forms.TextBox();
            this.lbltensinhvien = new System.Windows.Forms.Label();
            this.txtmasinhvien = new System.Windows.Forms.TextBox();
            this.lblmasinhvien = new System.Windows.Forms.Label();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.grpthongtinsinhvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ SINH VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpthongtinsinhvien
            // 
            this.grpthongtinsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpthongtinsinhvien.Controls.Add(this.btnxoa);
            this.grpthongtinsinhvien.Controls.Add(this.btnsua);
            this.grpthongtinsinhvien.Controls.Add(this.btnthem);
            this.grpthongtinsinhvien.Controls.Add(this.cbgioitinh);
            this.grpthongtinsinhvien.Controls.Add(this.cbkhoa);
            this.grpthongtinsinhvien.Controls.Add(this.lblkhoa);
            this.grpthongtinsinhvien.Controls.Add(this.txtlop);
            this.grpthongtinsinhvien.Controls.Add(this.lbllop);
            this.grpthongtinsinhvien.Controls.Add(this.txtdiachi);
            this.grpthongtinsinhvien.Controls.Add(this.lbldiachi);
            this.grpthongtinsinhvien.Controls.Add(this.txtsdt);
            this.grpthongtinsinhvien.Controls.Add(this.lblsdt);
            this.grpthongtinsinhvien.Controls.Add(this.txtnamsinh);
            this.grpthongtinsinhvien.Controls.Add(this.lblnamsinh);
            this.grpthongtinsinhvien.Controls.Add(this.lblgioitinh);
            this.grpthongtinsinhvien.Controls.Add(this.txttensinhvien);
            this.grpthongtinsinhvien.Controls.Add(this.lbltensinhvien);
            this.grpthongtinsinhvien.Controls.Add(this.txtmasinhvien);
            this.grpthongtinsinhvien.Controls.Add(this.lblmasinhvien);
            this.grpthongtinsinhvien.Location = new System.Drawing.Point(12, 84);
            this.grpthongtinsinhvien.Name = "grpthongtinsinhvien";
            this.grpthongtinsinhvien.Size = new System.Drawing.Size(864, 206);
            this.grpthongtinsinhvien.TabIndex = 1;
            this.grpthongtinsinhvien.TabStop = false;
            this.grpthongtinsinhvien.Text = "Thông Tin Sinh Viên";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(360, 178);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(270, 178);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(179, 178);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Location = new System.Drawing.Point(179, 99);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(121, 21);
            this.cbgioitinh.TabIndex = 2;
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(536, 132);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(121, 21);
            this.cbkhoa.TabIndex = 2;
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(461, 138);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(32, 13);
            this.lblkhoa.TabIndex = 0;
            this.lblkhoa.Text = "Khoa";
            // 
            // txtlop
            // 
            this.txtlop.Location = new System.Drawing.Point(536, 101);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(100, 20);
            this.txtlop.TabIndex = 1;
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Location = new System.Drawing.Point(461, 104);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(25, 13);
            this.lbllop.TabIndex = 0;
            this.lbllop.Text = "Lớp";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(536, 70);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(207, 20);
            this.txtdiachi.TabIndex = 1;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(461, 73);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(41, 13);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(536, 36);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 20);
            this.txtsdt.TabIndex = 1;
            this.txtsdt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(461, 40);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(29, 13);
            this.lblsdt.TabIndex = 0;
            this.lblsdt.Text = "SDT";
            // 
            // txtnamsinh
            // 
            this.txtnamsinh.Location = new System.Drawing.Point(179, 132);
            this.txtnamsinh.Name = "txtnamsinh";
            this.txtnamsinh.Size = new System.Drawing.Size(100, 20);
            this.txtnamsinh.TabIndex = 1;
            // 
            // lblnamsinh
            // 
            this.lblnamsinh.AutoSize = true;
            this.lblnamsinh.Location = new System.Drawing.Point(83, 135);
            this.lblnamsinh.Name = "lblnamsinh";
            this.lblnamsinh.Size = new System.Drawing.Size(53, 13);
            this.lblnamsinh.TabIndex = 0;
            this.lblnamsinh.Text = "Năm Sinh";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(83, 104);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(51, 13);
            this.lblgioitinh.TabIndex = 0;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // txttensinhvien
            // 
            this.txttensinhvien.Location = new System.Drawing.Point(179, 67);
            this.txttensinhvien.Name = "txttensinhvien";
            this.txttensinhvien.Size = new System.Drawing.Size(236, 20);
            this.txttensinhvien.TabIndex = 1;
            // 
            // lbltensinhvien
            // 
            this.lbltensinhvien.AutoSize = true;
            this.lbltensinhvien.Location = new System.Drawing.Point(83, 70);
            this.lbltensinhvien.Name = "lbltensinhvien";
            this.lbltensinhvien.Size = new System.Drawing.Size(74, 13);
            this.lbltensinhvien.TabIndex = 0;
            this.lbltensinhvien.Text = "Tên Sinh Viên";
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.Location = new System.Drawing.Point(179, 36);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.Size = new System.Drawing.Size(152, 20);
            this.txtmasinhvien.TabIndex = 1;
            // 
            // lblmasinhvien
            // 
            this.lblmasinhvien.AutoSize = true;
            this.lblmasinhvien.Location = new System.Drawing.Point(83, 42);
            this.lblmasinhvien.Name = "lblmasinhvien";
            this.lblmasinhvien.Size = new System.Drawing.Size(70, 13);
            this.lblmasinhvien.TabIndex = 0;
            this.lblmasinhvien.Text = "Mã Sinh Viên";
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.AllowUserToAddRows = false;
            this.dgvsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Location = new System.Drawing.Point(12, 304);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.RowHeadersWidth = 51;
            this.dgvsinhvien.RowTemplate.Height = 24;
            this.dgvsinhvien.Size = new System.Drawing.Size(866, 225);
            this.dgvsinhvien.TabIndex = 2;
            this.dgvsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellContentClick);
            // 
            // QuanLiSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 564);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.grpthongtinsinhvien);
            this.Controls.Add(this.label1);
            this.Name = "QuanLiSinhVien";
            this.Text = "QuanLiSinhVien";
            this.Load += new System.EventHandler(this.QuanLiSinhVien_Load);
            this.grpthongtinsinhvien.ResumeLayout(false);
            this.grpthongtinsinhvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpthongtinsinhvien;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txtnamsinh;
        private System.Windows.Forms.Label lblnamsinh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.TextBox txttensinhvien;
        private System.Windows.Forms.Label lbltensinhvien;
        private System.Windows.Forms.TextBox txtmasinhvien;
        private System.Windows.Forms.Label lblmasinhvien;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvsinhvien;
    }
}