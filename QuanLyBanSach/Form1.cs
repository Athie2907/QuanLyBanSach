
using Microsoft.EntityFrameworkCore;
using QuanLyBanSach.Data;
using QuanLyBanSach.Models;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class Form1 : Form
    {
        private int? maLoaiSachDangChon = null;
        private int? maSachDangChon = null;
        private int? maHoaDonDangChon = null;
        private int? maPhieuNhapDangChon = null;

        public Form1()
        {
            InitializeComponent();

            KiemTraKetNoi();

            // Gắn sự kiện cho các nút Loại Sách
            btnLoaiSachThem.Click += btnLoaiSachThem_Click;
            btnLoaiSachSua.Click += btnLoaiSachSua_Click;
            btnLoaiSachXoa.Click += btnLoaiSachXoa_Click;

            // Gắn sự kiện chọn dòng
            dgLoaiSach.CellClick += dataGridView1_CellClick;

            // Cấu hình bảng
            dgLoaiSach.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgLoaiSach.ReadOnly = true;
            dgLoaiSach.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgLoaiSach.MultiSelect = false;

            // Hiển thị danh sách loại sách
            LoadLoaiSach();

            // Gắn sự kiện cho các nút Sách
            btnSachThem.Click += btnSachThem_Click;
            btnSachSua.Click += btnSachSua_Click;
            btnSachXoa.Click += btnSachXoa_Click;

            // Gắn sự kiện chọn dòng sách
            dgSach.CellClick += dgSach_CellClick;

            // Cấu hình bảng sách
            dgSach.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgSach.ReadOnly = true;

            dgSach.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgSach.MultiSelect = false;

            // Tải dữ liệu sách và loại sách
            LoadLoaiSachComboBox();
            LoadSach();


            btnHoaDonThem.Click += btnHoaDonThem_Click;
            btnHoaDonSua.Click += btnHoaDonSua_Click;
            btnHoaDonXoa.Click += btnHoaDonXoa_Click;
            dgHoaDon.CellClick += dgHoaDon_CellClick;

            dgHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgHoaDon.ReadOnly = true;
            dgHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgHoaDon.MultiSelect = false;

            LoadHoaDon();


            btnPhieuNhapThem.Click += btnPhieuNhapThem_Click;
            btnPhieuNhapSua.Click += btnPhieuNhapSua_Click;
            btnPhieuNhapXoa.Click += btnPhieuNhapXoa_Click;
            dgPhieuNhap.CellClick += dgPhieuNhap_CellClick;

            dgPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhieuNhap.ReadOnly = true;
            dgPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPhieuNhap.MultiSelect = false;

            LoadPhieuNhap();
        }

        private void KiemTraKetNoi()
        {
            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    if (db.Database.CanConnect())
                    {
                        MessageBox.Show(
                            "Kết nối SQL Server thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết nối database!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // Hiển thị danh sách loại sách
        private void LoadLoaiSach()
        {
            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var danhSach = db.LoaiSachs
                        .Select(x => new
                        {
                            x.MaLoaiSach,
                            x.TenLoaiSach
                        })
                        .ToList();

                    dgLoaiSach.DataSource = danhSach;

                    dgLoaiSach.Columns["MaLoaiSach"]
                        .HeaderText = "Mã Loại Sách";

                    dgLoaiSach.Columns["TenLoaiSach"]
                        .HeaderText = "Tên Loại Sách";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
        }

        // Chọn một dòng trong DataGridView
        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgLoaiSach.Rows[e.RowIndex];

                maLoaiSachDangChon = Convert.ToInt32(
                    row.Cells["MaLoaiSach"].Value
                );

                txtLoaiSachTen.Text =
                    row.Cells["TenLoaiSach"].Value?.ToString();
            }
        }

        // Thêm loại sách
        private void btnLoaiSachThem_Click(
            object sender, EventArgs e)
        {
            string tenLoaiSach = txtLoaiSachTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLoaiSach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách!");
                txtLoaiSachTen.Focus();
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    bool daTonTai = db.LoaiSachs
                        .Any(x => x.TenLoaiSach == tenLoaiSach);

                    if (daTonTai)
                    {
                        MessageBox.Show("Loại sách này đã tồn tại!");
                        return;
                    }

                    LoaiSach loaiSach = new LoaiSach
                    {
                        TenLoaiSach = tenLoaiSach
                    };

                    db.LoaiSachs.Add(loaiSach);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm loại sách thành công!");

                LoadLoaiSach();
                LamMoiLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm loại sách: " + ex.Message);
            }
        }

        // Sửa loại sách
        private void btnLoaiSachSua_Click(
            object sender, EventArgs e)
        {
            if (maLoaiSachDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn loại sách cần sửa!");
                return;
            }

            string tenLoaiSach = txtLoaiSachTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenLoaiSach))
            {
                MessageBox.Show("Vui lòng nhập tên loại sách!");
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var loaiSach = db.LoaiSachs
                        .FirstOrDefault(x =>
                            x.MaLoaiSach == maLoaiSachDangChon.Value);

                    if (loaiSach == null)
                    {
                        MessageBox.Show("Không tìm thấy loại sách!");
                        return;
                    }

                    bool trungTen = db.LoaiSachs.Any(x =>
                        x.TenLoaiSach == tenLoaiSach &&
                        x.MaLoaiSach != maLoaiSachDangChon.Value);

                    if (trungTen)
                    {
                        MessageBox.Show("Tên loại sách đã tồn tại!");
                        return;
                    }

                    loaiSach.TenLoaiSach = tenLoaiSach;

                    db.SaveChanges();
                }

                MessageBox.Show("Sửa loại sách thành công!");

                LoadLoaiSach();
                LamMoiLoaiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa loại sách: " + ex.Message);
            }
        }

        // Xóa loại sách
        private void btnLoaiSachXoa_Click(
            object sender, EventArgs e)
        {
            if (maLoaiSachDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn loại sách cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa loại sách này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
            {
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var loaiSach = db.LoaiSachs
                        .FirstOrDefault(x =>
                            x.MaLoaiSach == maLoaiSachDangChon.Value);

                    if (loaiSach == null)
                    {
                        MessageBox.Show("Không tìm thấy loại sách!");
                        return;
                    }

                    db.LoaiSachs.Remove(loaiSach);
                    db.SaveChanges();
                }

                MessageBox.Show("Xóa loại sách thành công!");

                LoadLoaiSach();
                LamMoiLoaiSach();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa loại sách này vì đang có sách thuộc loại sách đó!"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa loại sách: " + ex.Message);
            }
        }

        // Làm trống ô nhập liệu
        private void LamMoiLoaiSach()
        {
            txtLoaiSachTen.Clear();
            maLoaiSachDangChon = null;
            dgLoaiSach.ClearSelection();
        }

        private void LoadLoaiSachComboBox()
        {
            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var danhSach = db.LoaiSachs
                        .OrderBy(x => x.TenLoaiSach)
                        .ToList();

                    cbSachLoaiSach.DataSource = danhSach;
                    cbSachLoaiSach.DisplayMember = "TenLoaiSach";
                    cbSachLoaiSach.ValueMember = "MaLoaiSach";
                    cbSachLoaiSach.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải loại sách: " + ex.Message
                );
            }
        }

        private void LoadSach()
        {
            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var danhSach = db.Saches
                        .Select(x => new
                        {
                            x.MaSach,
                            x.TenSach,
                            TenLoaiSach = x.LoaiSach != null
                                ? x.LoaiSach.TenLoaiSach
                                : "Chưa phân loại",
                            x.TacGia,
                            x.SoLuong,
                            x.GiaBan
                        })
                        .ToList();

                    dgSach.DataSource = danhSach;

                    dgSach.Columns["MaSach"].HeaderText = "Mã Sách";
                    dgSach.Columns["TenSach"].HeaderText = "Tên Sách";
                    dgSach.Columns["TenLoaiSach"].HeaderText = "Loại Sách";
                    dgSach.Columns["TacGia"].HeaderText = "Tác Giả";
                    dgSach.Columns["SoLuong"].HeaderText = "Số Lượng";
                    dgSach.Columns["GiaBan"].HeaderText = "Giá Bán";

                    dgSach.Columns["GiaBan"].DefaultCellStyle
                        .Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách sách: " + ex.Message
                );
            }
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgSach.Rows[e.RowIndex];

            maSachDangChon = Convert.ToInt32(
                row.Cells["MaSach"].Value
            );

            txtSachTenSach.Text =
                row.Cells["TenSach"].Value?.ToString() ?? "";

            txtSachTacGia.Text =
                row.Cells["TacGia"].Value?.ToString() ?? "";

            numSachSoLuong.Value =
                row.Cells["SoLuong"].Value == null ||
                row.Cells["SoLuong"].Value == DBNull.Value
                ? 0
                : Math.Clamp(
                    Convert.ToDecimal(row.Cells["SoLuong"].Value),
                    numSachSoLuong.Minimum,
                    numSachSoLuong.Maximum
                );

            numSachGiaBan.Value =
                row.Cells["GiaBan"].Value == null ||
                row.Cells["GiaBan"].Value == DBNull.Value
                ? 0
                : Math.Clamp(
                    Convert.ToDecimal(row.Cells["GiaBan"].Value),
                    numSachGiaBan.Minimum,
                    numSachGiaBan.Maximum
                );

            using (QuanLyBanSachContext db =
                new QuanLyBanSachContext())
            {
                var maLoai = db.Saches
                    .Where(x => x.MaSach == maSachDangChon.Value)
                    .Select(x => x.MaLoaiSach)
                    .FirstOrDefault();

                cbSachLoaiSach.SelectedValue = maLoai;

                if (maLoai == null)
                    cbSachLoaiSach.SelectedIndex = -1;
            }
        }

        private void btnSachThem_Click(object sender, EventArgs e)
        {
            string tenSach = txtSachTenSach.Text.Trim();
            string tacGia = txtSachTacGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Vui lòng nhập tên sách!");
                txtSachTenSach.Focus();
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    Sach sach = new Sach
                    {
                        TenSach = tenSach,
                        TacGia = string.IsNullOrWhiteSpace(tacGia)
                            ? null : tacGia,
                        MaLoaiSach = cbSachLoaiSach.SelectedValue == null
                            ? null
                            : Convert.ToInt32(cbSachLoaiSach.SelectedValue),
                        SoLuong = Convert.ToInt32(numSachSoLuong.Value),
                        GiaBan = numSachGiaBan.Value
                    };

                    db.Saches.Add(sach);
                    db.SaveChanges();
                }

                MessageBox.Show("Thêm sách thành công!");

                LoadSach();
                LoadLoaiSachComboBox();
                LamMoiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sách: " + ex.Message);
            }
        }

        private void btnSachSua_Click(object sender, EventArgs e)
        {
            if (maSachDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!");
                return;
            }

            string tenSach = txtSachTenSach.Text.Trim();
            string tacGia = txtSachTacGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Vui lòng nhập tên sách!");
                txtSachTenSach.Focus();
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var sach = db.Saches
                        .FirstOrDefault(x =>
                            x.MaSach == maSachDangChon.Value);

                    if (sach == null)
                    {
                        MessageBox.Show("Không tìm thấy sách!");
                        return;
                    }

                    sach.TenSach = tenSach;
                    sach.TacGia = string.IsNullOrWhiteSpace(tacGia)
                        ? null : tacGia;

                    sach.MaLoaiSach =
                        cbSachLoaiSach.SelectedValue == null
                        ? null
                        : Convert.ToInt32(cbSachLoaiSach.SelectedValue);

                    sach.SoLuong = Convert.ToInt32(numSachSoLuong.Value);
                    sach.GiaBan = numSachGiaBan.Value;

                    db.SaveChanges();
                }

                MessageBox.Show("Cập nhật sách thành công!");

                LoadSach();
                LoadLoaiSachComboBox();
                LamMoiSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sách: " + ex.Message);
            }
        }

        private void btnSachXoa_Click(object sender, EventArgs e)
        {
            if (maSachDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sách này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.No)
            {
                return;
            }

            try
            {
                using (QuanLyBanSachContext db =
                    new QuanLyBanSachContext())
                {
                    var sach = db.Saches
                        .FirstOrDefault(x =>
                            x.MaSach == maSachDangChon.Value);

                    if (sach == null)
                    {
                        MessageBox.Show("Không tìm thấy sách!");
                        return;
                    }

                    db.Saches.Remove(sach);
                    db.SaveChanges();
                }

                MessageBox.Show("Xóa sách thành công!");

                LoadSach();
                LamMoiSach();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show(
                    "Không thể xóa sách này vì sách đã có trong hóa đơn hoặc phiếu nhập!"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sách: " + ex.Message);
            }
        }

        private void LamMoiSach()
        {
            txtSachTenSach.Clear();
            txtSachTacGia.Clear();

            cbSachLoaiSach.SelectedIndex = -1;

            numSachSoLuong.Value = 0;
            numSachGiaBan.Value = 0;

            maSachDangChon = null;

            dgSach.ClearSelection();
        }

        private void LoadHoaDon()
        {
            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                var danhSach = db.HoaDons
                    .Select(x => new
                    {
                        x.MaHoaDon,
                        x.NgayLapHoaDon,
                        x.TenKhachHang,
                        x.SdtKhachHang
                    })
                    .ToList();

                dgHoaDon.DataSource = danhSach;

                dgHoaDon.Columns["MaHoaDon"].HeaderText = "Mã hóa đơn";
                dgHoaDon.Columns["NgayLapHoaDon"].HeaderText = "Ngày lập";
                dgHoaDon.Columns["TenKhachHang"].HeaderText = "Tên khách hàng";
                dgHoaDon.Columns["SdtKhachHang"].HeaderText = "Số điện thoại";
            }
        }

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgHoaDon.Rows[e.RowIndex];

            maHoaDonDangChon = Convert.ToInt32(row.Cells["MaHoaDon"].Value);

            txtHoaDonTenKH.Text = row.Cells["TenKhachHang"].Value?.ToString() ?? "";
            txtHoaDonSDTKH.Text = row.Cells["SdtKhachHang"].Value?.ToString() ?? "";

            if (row.Cells["NgayLapHoaDon"].Value != null &&
                row.Cells["NgayLapHoaDon"].Value != DBNull.Value)
            {
                dateNgayLapHoaDon.Value =
                    Convert.ToDateTime(row.Cells["NgayLapHoaDon"].Value);
            }
        }

        private void btnHoaDonThem_Click(object sender, EventArgs e)
        {

            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                HoaDon hoaDon = new HoaDon
                {
                    NgayLapHoaDon = dateNgayLapHoaDon.Value.Date,
                    TenKhachHang = string.IsNullOrWhiteSpace(txtHoaDonTenKH.Text) ? null : txtHoaDonTenKH.Text.Trim(),

                    SdtKhachHang = string.IsNullOrWhiteSpace(txtHoaDonSDTKH.Text) ? null : txtHoaDonSDTKH.Text.Trim()
                };

                db.HoaDons.Add(hoaDon);
                db.SaveChanges();
            }

            MessageBox.Show("Thêm hóa đơn thành công!");

            LoadHoaDon();
            LamMoiHoaDon();
        }

        private void btnHoaDonSua_Click(object sender, EventArgs e)
        {
            if (maHoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!");
                return;
            }

            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                var hoaDon = db.HoaDons
                    .FirstOrDefault(x => x.MaHoaDon == maHoaDonDangChon);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn!");
                    return;
                }

                hoaDon.NgayLapHoaDon = dateNgayLapHoaDon.Value.Date;
                hoaDon.TenKhachHang = string.IsNullOrWhiteSpace(txtHoaDonTenKH.Text) ? null : txtHoaDonTenKH.Text.Trim();
                hoaDon.SdtKhachHang = string.IsNullOrWhiteSpace(txtHoaDonSDTKH.Text) ? null : txtHoaDonSDTKH.Text.Trim();

                db.SaveChanges();
            }

            MessageBox.Show("Cập nhật hóa đơn thành công!");

            LoadHoaDon();
            LamMoiHoaDon();
        }
        private void btnHoaDonXoa_Click(object sender, EventArgs e)
        {
            if (maHoaDonDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa hóa đơn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                bool coChiTiet = db.ChiTietHoaDons
                    .Any(x => x.MaHoaDon == maHoaDonDangChon);

                if (coChiTiet)
                {
                    MessageBox.Show(
                        "Không thể xóa hóa đơn đã có chi tiết hóa đơn!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                var hoaDon = db.HoaDons
                    .FirstOrDefault(x => x.MaHoaDon == maHoaDonDangChon);

                if (hoaDon != null)
                {
                    db.HoaDons.Remove(hoaDon);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Xóa hóa đơn thành công!");

            LoadHoaDon();
            LamMoiHoaDon();
        }
        private void LamMoiHoaDon()
        {
            maHoaDonDangChon = null;

            txtHoaDonTenKH.Clear();
            txtHoaDonSDTKH.Clear();

            dateNgayLapHoaDon.Value = DateTime.Today;

            dgHoaDon.ClearSelection();
        }

        private void LoadPhieuNhap()
        {
            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                var danhSach = db.PhieuNhaps
                    .Select(x => new
                    {
                        x.MaPhieuNhap,
                        x.NgayLapPhieuNhap,
                        x.TenNhaCungCap
                    })
                    .ToList();

                dgPhieuNhap.DataSource = danhSach;

                dgPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã phiếu nhập";
                dgPhieuNhap.Columns["NgayLapPhieuNhap"].HeaderText = "Ngày lập phiếu";
                dgPhieuNhap.Columns["TenNhaCungCap"].HeaderText = "Nhà cung cấp";
            }
        }

        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgPhieuNhap.Rows[e.RowIndex];

            maPhieuNhapDangChon = Convert.ToInt32(
                row.Cells["MaPhieuNhap"].Value
            );

            txtPhieuNhapNhaCungCap.Text =
                row.Cells["TenNhaCungCap"].Value?.ToString() ?? "";

            if (row.Cells["NgayLapPhieuNhap"].Value != null &&
                row.Cells["NgayLapPhieuNhap"].Value != DBNull.Value)
            {
                dateNgayLapPhieu.Value = Convert.ToDateTime(
                    row.Cells["NgayLapPhieuNhap"].Value
                );
            }
        }

        private void btnPhieuNhapThem_Click(object sender, EventArgs e)
        {
            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                PhieuNhap phieuNhap = new PhieuNhap
                {
                    NgayLapPhieuNhap = dateNgayLapPhieu.Value.Date,

                    TenNhaCungCap = string.IsNullOrWhiteSpace(
                        txtPhieuNhapNhaCungCap.Text)
                        ? null
                        : txtPhieuNhapNhaCungCap.Text.Trim()
                };

                db.PhieuNhaps.Add(phieuNhap);
                db.SaveChanges();
            }

            MessageBox.Show("Thêm phiếu nhập thành công!");

            LoadPhieuNhap();
            LamMoiPhieuNhap();
        }

        private void btnPhieuNhapSua_Click(object sender, EventArgs e)
        {
            if (maPhieuNhapDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần sửa!");
                return;
            }

            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                var phieuNhap = db.PhieuNhaps
                    .FirstOrDefault(x => x.MaPhieuNhap == maPhieuNhapDangChon);

                if (phieuNhap == null)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập!");
                    return;
                }

                phieuNhap.NgayLapPhieuNhap = dateNgayLapPhieu.Value.Date;

                phieuNhap.TenNhaCungCap = string.IsNullOrWhiteSpace(
                    txtPhieuNhapNhaCungCap.Text)
                    ? null
                    : txtPhieuNhapNhaCungCap.Text.Trim();

                db.SaveChanges();
            }

            MessageBox.Show("Cập nhật phiếu nhập thành công!");

            LoadPhieuNhap();
            LamMoiPhieuNhap();
        }

        private void btnPhieuNhapXoa_Click(object sender, EventArgs e)
        {
            if (maPhieuNhapDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa phiếu nhập này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
                return;

            using (QuanLyBanSachContext db = new QuanLyBanSachContext())
            {
                bool coChiTiet = db.ChiTietPhieuNhaps
                    .Any(x => x.MaPhieuNhap == maPhieuNhapDangChon);

                if (coChiTiet)
                {
                    MessageBox.Show(
                        "Không thể xóa phiếu nhập đã có chi tiết phiếu nhập!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                var phieuNhap = db.PhieuNhaps
                    .FirstOrDefault(x => x.MaPhieuNhap == maPhieuNhapDangChon);

                if (phieuNhap != null)
                {
                    db.PhieuNhaps.Remove(phieuNhap);
                    db.SaveChanges();
                }
            }

            MessageBox.Show("Xóa phiếu nhập thành công!");

            LoadPhieuNhap();
            LamMoiPhieuNhap();
        }

        private void LamMoiPhieuNhap()
        {
            maPhieuNhapDangChon = null;

            txtPhieuNhapNhaCungCap.Clear();
            dateNgayLapPhieu.Value = DateTime.Today;

            dgPhieuNhap.ClearSelection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
