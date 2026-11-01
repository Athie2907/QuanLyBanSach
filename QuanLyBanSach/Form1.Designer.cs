namespace QuanLyBanSach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            numSachGiaBan = new NumericUpDown();
            numSachSoLuong = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            cbSachLoaiSach = new ComboBox();
            label3 = new Label();
            txtSachTacGia = new TextBox();
            label2 = new Label();
            txtSachTenSach = new TextBox();
            label1 = new Label();
            btnSachSua = new Button();
            btnSachXoa = new Button();
            btnSachThem = new Button();
            dgSach = new DataGridView();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            txtLoaiSachTen = new TextBox();
            label10 = new Label();
            btnLoaiSachSua = new Button();
            btnLoaiSachXoa = new Button();
            btnLoaiSachThem = new Button();
            dgLoaiSach = new DataGridView();
            tabPage3 = new TabPage();
            panel3 = new Panel();
            txtHoaDonSDTKH = new TextBox();
            txtHoaDonTenKH = new TextBox();
            label6 = new Label();
            dateNgayLapHoaDon = new DateTimePicker();
            label8 = new Label();
            label11 = new Label();
            btnHoaDonSua = new Button();
            btnHoaDonXoa = new Button();
            btnHoaDonThem = new Button();
            dgHoaDon = new DataGridView();
            tabPage4 = new TabPage();
            panel4 = new Panel();
            txtPhieuNhapNhaCungCap = new TextBox();
            dateNgayLapPhieu = new DateTimePicker();
            label9 = new Label();
            label12 = new Label();
            btnPhieuNhapSua = new Button();
            btnPhieuNhapXoa = new Button();
            btnPhieuNhapThem = new Button();
            dgPhieuNhap = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSachGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSachSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSach).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgLoaiSach).BeginInit();
            tabPage3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).BeginInit();
            tabPage4.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(4, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1094, 533);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(dgSach);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1086, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sách";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(numSachGiaBan);
            panel1.Controls.Add(numSachSoLuong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cbSachLoaiSach);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSachTacGia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSachTenSach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSachSua);
            panel1.Controls.Add(btnSachXoa);
            panel1.Controls.Add(btnSachThem);
            panel1.Location = new Point(6, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 147);
            panel1.TabIndex = 1;
            // 
            // numSachGiaBan
            // 
            numSachGiaBan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSachGiaBan.Location = new Point(751, 78);
            numSachGiaBan.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numSachGiaBan.Name = "numSachGiaBan";
            numSachGiaBan.Size = new Size(186, 28);
            numSachGiaBan.TabIndex = 13;
            // 
            // numSachSoLuong
            // 
            numSachSoLuong.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numSachSoLuong.Location = new Point(552, 77);
            numSachSoLuong.Name = "numSachSoLuong";
            numSachSoLuong.Size = new Size(79, 28);
            numSachSoLuong.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(670, 81);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 10;
            label5.Text = "Giá Bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 81);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 9;
            label4.Text = "Số Lượng";
            // 
            // cbSachLoaiSach
            // 
            cbSachLoaiSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSachLoaiSach.FormattingEnabled = true;
            cbSachLoaiSach.Location = new Point(122, 76);
            cbSachLoaiSach.Name = "cbSachLoaiSach";
            cbSachLoaiSach.Size = new Size(324, 30);
            cbSachLoaiSach.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 79);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 7;
            label3.Text = "Loại Sách";
            // 
            // txtSachTacGia
            // 
            txtSachTacGia.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSachTacGia.Location = new Point(552, 36);
            txtSachTacGia.Name = "txtSachTacGia";
            txtSachTacGia.Size = new Size(206, 28);
            txtSachTacGia.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 39);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 5;
            label2.Text = "Tác Giả";
            // 
            // txtSachTenSach
            // 
            txtSachTenSach.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSachTenSach.Location = new Point(122, 34);
            txtSachTenSach.Name = "txtSachTenSach";
            txtSachTenSach.Size = new Size(324, 28);
            txtSachTenSach.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 3;
            label1.Text = "Tên Sách";
            // 
            // btnSachSua
            // 
            btnSachSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSachSua.Location = new Point(961, 58);
            btnSachSua.Name = "btnSachSua";
            btnSachSua.Size = new Size(101, 34);
            btnSachSua.TabIndex = 2;
            btnSachSua.Text = "Sửa";
            btnSachSua.UseVisualStyleBackColor = true;
            // 
            // btnSachXoa
            // 
            btnSachXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSachXoa.Location = new Point(961, 98);
            btnSachXoa.Name = "btnSachXoa";
            btnSachXoa.Size = new Size(101, 34);
            btnSachXoa.TabIndex = 1;
            btnSachXoa.Text = "Xóa";
            btnSachXoa.UseVisualStyleBackColor = true;
            // 
            // btnSachThem
            // 
            btnSachThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSachThem.Location = new Point(961, 18);
            btnSachThem.Name = "btnSachThem";
            btnSachThem.Size = new Size(101, 34);
            btnSachThem.TabIndex = 0;
            btnSachThem.Text = "Thêm";
            btnSachThem.UseVisualStyleBackColor = true;
            // 
            // dgSach
            // 
            dgSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSach.Location = new Point(6, 12);
            dgSach.Name = "dgSach";
            dgSach.RowHeadersWidth = 62;
            dgSach.Size = new Size(1065, 275);
            dgSach.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(dgLoaiSach);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1086, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Loại Sách";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtLoaiSachTen);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(btnLoaiSachSua);
            panel2.Controls.Add(btnLoaiSachXoa);
            panel2.Controls.Add(btnLoaiSachThem);
            panel2.Location = new Point(6, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 127);
            panel2.TabIndex = 3;
            // 
            // txtLoaiSachTen
            // 
            txtLoaiSachTen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoaiSachTen.Location = new Point(270, 47);
            txtLoaiSachTen.Name = "txtLoaiSachTen";
            txtLoaiSachTen.Size = new Size(324, 28);
            txtLoaiSachTen.TabIndex = 4;
            txtLoaiSachTen.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(119, 50);
            label10.Name = "label10";
            label10.Size = new Size(127, 22);
            label10.TabIndex = 3;
            label10.Text = "Tên Loại Sách";
            // 
            // btnLoaiSachSua
            // 
            btnLoaiSachSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiSachSua.Location = new Point(897, 47);
            btnLoaiSachSua.Name = "btnLoaiSachSua";
            btnLoaiSachSua.Size = new Size(101, 34);
            btnLoaiSachSua.TabIndex = 2;
            btnLoaiSachSua.Text = "Sửa";
            btnLoaiSachSua.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSachXoa
            // 
            btnLoaiSachXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiSachXoa.Location = new Point(897, 87);
            btnLoaiSachXoa.Name = "btnLoaiSachXoa";
            btnLoaiSachXoa.Size = new Size(101, 34);
            btnLoaiSachXoa.TabIndex = 1;
            btnLoaiSachXoa.Text = "Xóa";
            btnLoaiSachXoa.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSachThem
            // 
            btnLoaiSachThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoaiSachThem.Location = new Point(897, 7);
            btnLoaiSachThem.Name = "btnLoaiSachThem";
            btnLoaiSachThem.Size = new Size(101, 34);
            btnLoaiSachThem.TabIndex = 0;
            btnLoaiSachThem.Text = "Thêm";
            btnLoaiSachThem.UseVisualStyleBackColor = true;
            // 
            // dgLoaiSach
            // 
            dgLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgLoaiSach.Location = new Point(6, 12);
            dgLoaiSach.Name = "dgLoaiSach";
            dgLoaiSach.RowHeadersWidth = 62;
            dgLoaiSach.Size = new Size(1065, 287);
            dgLoaiSach.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(dgHoaDon);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1086, 495);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hóa Đơn";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtHoaDonSDTKH);
            panel3.Controls.Add(txtHoaDonTenKH);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dateNgayLapHoaDon);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(btnHoaDonSua);
            panel3.Controls.Add(btnHoaDonXoa);
            panel3.Controls.Add(btnHoaDonThem);
            panel3.Location = new Point(6, 305);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 135);
            panel3.TabIndex = 3;
            // 
            // txtHoaDonSDTKH
            // 
            txtHoaDonSDTKH.Location = new Point(679, 78);
            txtHoaDonSDTKH.Name = "txtHoaDonSDTKH";
            txtHoaDonSDTKH.Size = new Size(257, 30);
            txtHoaDonSDTKH.TabIndex = 18;
            // 
            // txtHoaDonTenKH
            // 
            txtHoaDonTenKH.Location = new Point(179, 78);
            txtHoaDonTenKH.Name = "txtHoaDonTenKH";
            txtHoaDonTenKH.Size = new Size(337, 30);
            txtHoaDonTenKH.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(522, 81);
            label6.Name = "label6";
            label6.Size = new Size(151, 22);
            label6.TabIndex = 15;
            label6.Text = "SDT Khách Hàng";
            // 
            // dateNgayLapHoaDon
            // 
            dateNgayLapHoaDon.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNgayLapHoaDon.Location = new Point(179, 36);
            dateNgayLapHoaDon.Name = "dateNgayLapHoaDon";
            dateNgayLapHoaDon.Size = new Size(337, 28);
            dateNgayLapHoaDon.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 81);
            label8.Name = "label8";
            label8.Size = new Size(146, 22);
            label8.TabIndex = 7;
            label8.Text = "Tên Khách Hàng";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 39);
            label11.Name = "label11";
            label11.Size = new Size(163, 22);
            label11.TabIndex = 3;
            label11.Text = "Ngày Lập Hóa Đơn";
            // 
            // btnHoaDonSua
            // 
            btnHoaDonSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDonSua.Location = new Point(961, 51);
            btnHoaDonSua.Name = "btnHoaDonSua";
            btnHoaDonSua.Size = new Size(101, 34);
            btnHoaDonSua.TabIndex = 2;
            btnHoaDonSua.Text = "Sửa";
            btnHoaDonSua.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonXoa
            // 
            btnHoaDonXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDonXoa.Location = new Point(961, 91);
            btnHoaDonXoa.Name = "btnHoaDonXoa";
            btnHoaDonXoa.Size = new Size(101, 34);
            btnHoaDonXoa.TabIndex = 1;
            btnHoaDonXoa.Text = "Xóa";
            btnHoaDonXoa.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonThem
            // 
            btnHoaDonThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDonThem.Location = new Point(961, 11);
            btnHoaDonThem.Name = "btnHoaDonThem";
            btnHoaDonThem.Size = new Size(101, 34);
            btnHoaDonThem.TabIndex = 0;
            btnHoaDonThem.Text = "Thêm";
            btnHoaDonThem.UseVisualStyleBackColor = true;
            // 
            // dgHoaDon
            // 
            dgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgHoaDon.Location = new Point(6, 12);
            dgHoaDon.Name = "dgHoaDon";
            dgHoaDon.RowHeadersWidth = 62;
            dgHoaDon.Size = new Size(1065, 287);
            dgHoaDon.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(panel4);
            tabPage4.Controls.Add(dgPhieuNhap);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1086, 495);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Phiếu Nhập";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPhieuNhapNhaCungCap);
            panel4.Controls.Add(dateNgayLapPhieu);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(btnPhieuNhapSua);
            panel4.Controls.Add(btnPhieuNhapXoa);
            panel4.Controls.Add(btnPhieuNhapThem);
            panel4.Location = new Point(6, 317);
            panel4.Name = "panel4";
            panel4.Size = new Size(1065, 133);
            panel4.TabIndex = 5;
            // 
            // txtPhieuNhapNhaCungCap
            // 
            txtPhieuNhapNhaCungCap.Location = new Point(235, 77);
            txtPhieuNhapNhaCungCap.Name = "txtPhieuNhapNhaCungCap";
            txtPhieuNhapNhaCungCap.Size = new Size(337, 30);
            txtPhieuNhapNhaCungCap.TabIndex = 17;
            // 
            // dateNgayLapPhieu
            // 
            dateNgayLapPhieu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNgayLapPhieu.Location = new Point(258, 33);
            dateNgayLapPhieu.Name = "dateNgayLapPhieu";
            dateNgayLapPhieu.Size = new Size(337, 28);
            dateNgayLapPhieu.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(66, 80);
            label9.Name = "label9";
            label9.Size = new Size(166, 22);
            label9.TabIndex = 7;
            label9.Text = "Tên Nhà Cung Cấp";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(66, 38);
            label12.Name = "label12";
            label12.Size = new Size(186, 22);
            label12.TabIndex = 3;
            label12.Text = "Ngày Lập Phiếu Nhập";
            // 
            // btnPhieuNhapSua
            // 
            btnPhieuNhapSua.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuNhapSua.Location = new Point(940, 47);
            btnPhieuNhapSua.Name = "btnPhieuNhapSua";
            btnPhieuNhapSua.Size = new Size(101, 34);
            btnPhieuNhapSua.TabIndex = 2;
            btnPhieuNhapSua.Text = "Sửa";
            btnPhieuNhapSua.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhapXoa
            // 
            btnPhieuNhapXoa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuNhapXoa.Location = new Point(940, 87);
            btnPhieuNhapXoa.Name = "btnPhieuNhapXoa";
            btnPhieuNhapXoa.Size = new Size(101, 34);
            btnPhieuNhapXoa.TabIndex = 1;
            btnPhieuNhapXoa.Text = "Xóa";
            btnPhieuNhapXoa.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhapThem
            // 
            btnPhieuNhapThem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuNhapThem.Location = new Point(940, 7);
            btnPhieuNhapThem.Name = "btnPhieuNhapThem";
            btnPhieuNhapThem.Size = new Size(101, 34);
            btnPhieuNhapThem.TabIndex = 0;
            btnPhieuNhapThem.Text = "Thêm";
            btnPhieuNhapThem.UseVisualStyleBackColor = true;
            // 
            // dgPhieuNhap
            // 
            dgPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhieuNhap.Location = new Point(6, 12);
            dgPhieuNhap.Name = "dgPhieuNhap";
            dgPhieuNhap.RowHeadersWidth = 62;
            dgPhieuNhap.Size = new Size(1065, 299);
            dgPhieuNhap.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 492);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Bán Sách";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSachGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSachSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSach).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgLoaiSach).EndInit();
            tabPage3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgHoaDon).EndInit();
            tabPage4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgSach;
        private Panel panel1;
        private Button btnSachSua;
        private Button btnSachXoa;
        private Button btnSachThem;
        private ComboBox cbSachLoaiSach;
        private Label label3;
        private TextBox txtSachTacGia;
        private Label label2;
        private TextBox txtSachTenSach;
        private Label label1;
        private NumericUpDown numSachSoLuong;
        private Label label5;
        private Label label4;
        private NumericUpDown numSachGiaBan;
        private Panel panel2;
        private TextBox txtLoaiSachTen;
        private Label label10;
        private Button btnLoaiSachSua;
        private Button btnLoaiSachXoa;
        private Button btnLoaiSachThem;
        private DataGridView dgLoaiSach;
        private Panel panel3;
        private Label label8;
        private Label label11;
        private Button btnHoaDonSua;
        private Button btnHoaDonXoa;
        private Button btnHoaDonThem;
        private DataGridView dgHoaDon;
        private Label label6;
        private DateTimePicker dateNgayLapHoaDon;
        private TextBox txtHoaDonSDTKH;
        private TextBox txtHoaDonTenKH;
        private Panel panel4;
        private TextBox txtPhieuNhapNhaCungCap;
        private DateTimePicker dateNgayLapPhieu;
        private Label label9;
        private Label label12;
        private Button btnPhieuNhapSua;
        private Button btnPhieuNhapXoa;
        private Button btnPhieuNhapThem;
        private DataGridView dgPhieuNhap;
    }
}
