using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanlisinhvien
{
    public partial class DiemRenLuyen : Form
    {
        // Tạo lớp dữ liệu tạm cho điểm rèn luyện
        public class DiemRL
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string Lop { get; set; }
            public string HocKy { get; set; }
            public int TuDanhGia { get; set; }
            public int LopDanhGia { get; set; }
            public int KhoaDanhGia { get; set; }
            public int TongDiem { get; set; }
            public string XepLoai { get; set; }
        }

        // Danh sách dữ liệu tạm
        private List<DiemRL> dsDiem = new List<DiemRL>();

        public DiemRenLuyen()
        {
            InitializeComponent();
            LoadComboBox();
            HienThi();
        }

        private void LoadComboBox()
        {
            cmbHocKy.Items.Add("HK1 - 2025");
            cmbHocKy.Items.Add("HK2 - 2025");
            cmbHocKy.SelectedIndex = 0;
        }

        // ====== Xử lý nút Tính Điểm ======
        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            int tuDG = (int)nudTuDanhGia.Value;
            int lopDG = (int)nudLopDanhGia.Value;
            int khoaDG = (int)nudKhoaDanhGia.Value;

            int tong = (tuDG + lopDG + khoaDG) / 3;
            txtTongDiem.Text = tong.ToString();

            string xepLoai;
            if (tong >= 90) xepLoai = "Xuất sắc";
            else if (tong >= 80) xepLoai = "Tốt";
            else if (tong >= 65) xepLoai = "Khá";
            else if (tong >= 50) xepLoai = "Trung bình";
            else if (tong >= 35) xepLoai = "Yếu";
            else xepLoai = "Kém";

            cmbXepLoai.Text = xepLoai;
        }

        // ====== Thêm mới ======
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtLop.Clear();
            txtTongDiem.Clear();
            cmbXepLoai.SelectedIndex = -1;
            nudTuDanhGia.Value = nudLopDanhGia.Value = nudKhoaDanhGia.Value = 0;
        }

        // ====== Lưu ======
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DiemRL drl = new DiemRL()
            {
                MSSV = txtMSSV.Text,
                HoTen = txtHoTen.Text,
                Lop = txtLop.Text,
                HocKy = cmbHocKy.Text,
                TuDanhGia = (int)nudTuDanhGia.Value,
                LopDanhGia = (int)nudLopDanhGia.Value,
                KhoaDanhGia = (int)nudKhoaDanhGia.Value,
                TongDiem = int.Parse(txtTongDiem.Text == "" ? "0" : txtTongDiem.Text),
                XepLoai = cmbXepLoai.Text
            };

            dsDiem.Add(drl);
            HienThi();
            MessageBox.Show("Đã lưu điểm rèn luyện!");
        }

        // ====== Hiển thị danh sách lên DataGridView ======
        private void HienThi()
        {
            dgvDiemRenLuyen.DataSource = null;
            dgvDiemRenLuyen.DataSource = dsDiem;
        }

        // ====== Xóa dòng đang chọn ======
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiemRenLuyen.CurrentRow != null)
            {
                int index = dgvDiemRenLuyen.CurrentRow.Index;
                dsDiem.RemoveAt(index);
                HienThi();
            }
        }

        // ====== Sửa ======
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDiemRenLuyen.CurrentRow != null)
            {
                int index = dgvDiemRenLuyen.CurrentRow.Index;
                var drl = dsDiem[index];

                drl.MSSV = txtMSSV.Text;
                drl.HoTen = txtHoTen.Text;
                drl.Lop = txtLop.Text;
                drl.HocKy = cmbHocKy.Text;
                drl.TuDanhGia = (int)nudTuDanhGia.Value;
                drl.LopDanhGia = (int)nudLopDanhGia.Value;
                drl.KhoaDanhGia = (int)nudKhoaDanhGia.Value;
                drl.TongDiem = int.Parse(txtTongDiem.Text);
                drl.XepLoai = cmbXepLoai.Text;

                HienThi();
                MessageBox.Show("Cập nhật thành công!");
            }
        }
    }
}
