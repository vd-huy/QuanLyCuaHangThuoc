namespace BTL_HSK
{
    partial class FormNhanVien
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
            this.grbThuoc = new System.Windows.Forms.GroupBox();
            this.pnlGioiTinh = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txbPhuCap = new System.Windows.Forms.TextBox();
            this.txbLuongCoBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSDTSearch = new System.Windows.Forms.TextBox();
            this.txbTenNVSearch = new System.Windows.Forms.TextBox();
            this.txbMaNVSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnInNhanVien = new System.Windows.Forms.Button();
            this.grbThuoc.SuspendLayout();
            this.pnlGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThuoc
            // 
            this.grbThuoc.Controls.Add(this.pnlGioiTinh);
            this.grbThuoc.Controls.Add(this.txbPhuCap);
            this.grbThuoc.Controls.Add(this.txbLuongCoBan);
            this.grbThuoc.Controls.Add(this.label8);
            this.grbThuoc.Controls.Add(this.label1);
            this.grbThuoc.Controls.Add(this.txbDiaChi);
            this.grbThuoc.Controls.Add(this.txbSDT);
            this.grbThuoc.Controls.Add(this.dtpNgaySinh);
            this.grbThuoc.Controls.Add(this.label7);
            this.grbThuoc.Controls.Add(this.label6);
            this.grbThuoc.Controls.Add(this.label5);
            this.grbThuoc.Controls.Add(this.txbTenNV);
            this.grbThuoc.Controls.Add(this.txbMaNV);
            this.grbThuoc.Controls.Add(this.label4);
            this.grbThuoc.Controls.Add(this.label3);
            this.grbThuoc.Controls.Add(this.label2);
            this.grbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThuoc.Location = new System.Drawing.Point(11, 10);
            this.grbThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThuoc.Name = "grbThuoc";
            this.grbThuoc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbThuoc.Size = new System.Drawing.Size(977, 208);
            this.grbThuoc.TabIndex = 10;
            this.grbThuoc.TabStop = false;
            this.grbThuoc.Text = "Quản lý nhân viên";
            // 
            // pnlGioiTinh
            // 
            this.pnlGioiTinh.Controls.Add(this.rbNu);
            this.pnlGioiTinh.Controls.Add(this.rbNam);
            this.pnlGioiTinh.Location = new System.Drawing.Point(193, 118);
            this.pnlGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGioiTinh.Name = "pnlGioiTinh";
            this.pnlGioiTinh.Size = new System.Drawing.Size(231, 34);
            this.pnlGioiTinh.TabIndex = 30;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNu.Location = new System.Drawing.Point(148, 6);
            this.rbNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(51, 24);
            this.rbNu.TabIndex = 25;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbNam.Location = new System.Drawing.Point(6, 4);
            this.rbNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(65, 24);
            this.rbNam.TabIndex = 24;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txbPhuCap
            // 
            this.txbPhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbPhuCap.Location = new System.Drawing.Point(722, 171);
            this.txbPhuCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPhuCap.Name = "txbPhuCap";
            this.txbPhuCap.Size = new System.Drawing.Size(223, 26);
            this.txbPhuCap.TabIndex = 29;
            this.txbPhuCap.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbPhuCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhuCap_KeyPress);
            // 
            // txbLuongCoBan
            // 
            this.txbLuongCoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbLuongCoBan.Location = new System.Drawing.Point(193, 170);
            this.txbLuongCoBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbLuongCoBan.Name = "txbLuongCoBan";
            this.txbLuongCoBan.Size = new System.Drawing.Size(256, 26);
            this.txbLuongCoBan.TabIndex = 28;
            this.txbLuongCoBan.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbLuongCoBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLuongCoBan_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(569, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Phụ cấp :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Lương cơ bản :";
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDiaChi.Location = new System.Drawing.Point(722, 37);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(223, 26);
            this.txbDiaChi.TabIndex = 23;
            this.txbDiaChi.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbSDT.Location = new System.Drawing.Point(722, 85);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(223, 26);
            this.txbSDT.TabIndex = 22;
            this.txbSDT.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDT_KeyPress);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(722, 127);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(210, 23);
            this.dtpNgaySinh.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày sinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Số điện thoại :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Địa chỉ :";
            // 
            // txbTenNV
            // 
            this.txbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbTenNV.Location = new System.Drawing.Point(193, 83);
            this.txbTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(256, 26);
            this.txbTenNV.TabIndex = 16;
            this.txbTenNV.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbTenNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTenNV_KeyPress);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbMaNV.Location = new System.Drawing.Point(193, 40);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(256, 26);
            this.txbMaNV.TabIndex = 15;
            this.txbMaNV.TextChanged += new System.EventHandler(this.txbMaNV_TextChanged);
            this.txbMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMaNV_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giới tính :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã nhân viên :";
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXem.Location = new System.Drawing.Point(11, 230);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(96, 43);
            this.btnXem.TabIndex = 29;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(391, 230);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 43);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(259, 230);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 43);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(134, 230);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 43);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(11, 278);
            this.dtgvNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.RowHeadersWidth = 62;
            this.dtgvNhanVien.RowTemplate.Height = 28;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1357, 208);
            this.dtgvNhanVien.TabIndex = 32;
            this.dtgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbSDTSearch);
            this.groupBox1.Controls.Add(this.txbTenNVSearch);
            this.groupBox1.Controls.Add(this.txbMaNVSearch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(1005, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(367, 208);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txbSDTSearch
            // 
            this.txbSDTSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbSDTSearch.Location = new System.Drawing.Point(140, 130);
            this.txbSDTSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSDTSearch.Name = "txbSDTSearch";
            this.txbSDTSearch.Size = new System.Drawing.Size(223, 26);
            this.txbSDTSearch.TabIndex = 33;
            // 
            // txbTenNVSearch
            // 
            this.txbTenNVSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbTenNVSearch.Location = new System.Drawing.Point(140, 85);
            this.txbTenNVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTenNVSearch.Name = "txbTenNVSearch";
            this.txbTenNVSearch.Size = new System.Drawing.Size(223, 26);
            this.txbTenNVSearch.TabIndex = 32;
            // 
            // txbMaNVSearch
            // 
            this.txbMaNVSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbMaNVSearch.Location = new System.Drawing.Point(140, 37);
            this.txbMaNVSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaNVSearch.Name = "txbMaNVSearch";
            this.txbMaNVSearch.Size = new System.Drawing.Size(223, 26);
            this.txbMaNVSearch.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Tên nhân viên :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số điện thoại :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã nhân viên :";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(1256, 230);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(116, 43);
            this.btnTimKiem.TabIndex = 34;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInNhanVien
            // 
            this.btnInNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInNhanVien.Location = new System.Drawing.Point(572, 230);
            this.btnInNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInNhanVien.Name = "btnInNhanVien";
            this.btnInNhanVien.Size = new System.Drawing.Size(419, 43);
            this.btnInNhanVien.TabIndex = 35;
            this.btnInNhanVien.Text = "In danh sách nhân viên";
            this.btnInNhanVien.UseVisualStyleBackColor = true;
            this.btnInNhanVien.Click += new System.EventHandler(this.btnInNhanVien_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1383, 496);
            this.Controls.Add(this.btnInNhanVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.grbThuoc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.grbThuoc.ResumeLayout(false);
            this.grbThuoc.PerformLayout();
            this.pnlGioiTinh.ResumeLayout(false);
            this.pnlGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThuoc;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox txbPhuCap;
        private System.Windows.Forms.TextBox txbLuongCoBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Panel pnlGioiTinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbSDTSearch;
        private System.Windows.Forms.TextBox txbTenNVSearch;
        private System.Windows.Forms.TextBox txbMaNVSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnInNhanVien;
    }
}