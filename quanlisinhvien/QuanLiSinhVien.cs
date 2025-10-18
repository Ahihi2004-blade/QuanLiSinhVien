using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlisinhvien
{
    public partial class QuanLiSinhVien : Form
    {
        public QuanLiSinhVien()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BindingList<SinhVien> dsSinhVien = new BindingList<SinhVien>();
        private void QuanLiSinhVien_Load(object sender, EventArgs e)
        {
            cbgioitinh.Items.Add("Nam");
            cbgioitinh.Items.Add("Nữ");
            cbkhoa.Items.Add("CNTT");
            cbkhoa.Items.Add("QTKD");
            cbkhoa.Items.Add("Luật");
            cbkhoa.Items.Add("NNA");
            dgvsinhvien.DataSource = dsSinhVien;
            dgvsinhvien.AllowUserToAddRows = false; // KHÔNG cho tự thêm dòng trống
            dgvsinhvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnthem_Click(object sender, EventArgs e)
        { /// duy da sua pham them
            // Kiểm tra nhập đủ dữ liệu
            if (string.IsNullOrWhiteSpace(txtmasinhvien.Text) ||
                string.IsNullOrWhiteSpace(txttensinhvien.Text) ||
                string.IsNullOrWhiteSpace(txtnamsinh.Text) ||
                string.IsNullOrWhiteSpace(txtsdt.Text) ||
                string.IsNullOrWhiteSpace(txtdiachi.Text) ||
                string.IsNullOrWhiteSpace(txtlop.Text) ||
                string.IsNullOrWhiteSpace(cbgioitinh.Text) ||
                string.IsNullOrWhiteSpace(cbkhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng mã sinh viên
            foreach (var item in dsSinhVien)
            {
                if (item.MaSV == txtmasinhvien.Text)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dsSinhVien.Add(new SinhVien
            {
                MaSV = txtmasinhvien.Text,
                TenSV = txttensinhvien.Text,
                GioiTinh = cbgioitinh.Text,
                NamSinh = txtnamsinh.Text,
                SDT = txtsdt.Text,
                DiaChi = txtdiachi.Text,
                Lop = txtlop.Text,
                Khoa = cbkhoa.Text
            });

            MessageBox.Show("Đã thêm sinh viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTrang();
        }


        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvsinhvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmasinhvien.Text) ||
                string.IsNullOrWhiteSpace(txttensinhvien.Text) ||
                string.IsNullOrWhiteSpace(txtnamsinh.Text) ||
                string.IsNullOrWhiteSpace(txtsdt.Text) ||
                string.IsNullOrWhiteSpace(txtdiachi.Text) ||
                string.IsNullOrWhiteSpace(txtlop.Text) ||
                string.IsNullOrWhiteSpace(cbgioitinh.Text) ||
                string.IsNullOrWhiteSpace(cbkhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Lấy sinh viên đang chọn và cập nhật
            SinhVien sv = dgvsinhvien.CurrentRow.DataBoundItem as SinhVien;
            if (sv != null)
            {
                sv.MaSV = txtmasinhvien.Text;
                sv.TenSV = txttensinhvien.Text;
                sv.GioiTinh = cbgioitinh.Text;
                sv.NamSinh = txtnamsinh.Text;
                sv.SDT = txtsdt.Text;
                sv.DiaChi = txtdiachi.Text;
                sv.Lop = txtlop.Text;
                sv.Khoa = cbkhoa.Text;

                dgvsinhvien.Refresh();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvsinhvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SinhVien sv = dgvsinhvien.CurrentRow.DataBoundItem as SinhVien;
            if (sv != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dsSinhVien.Remove(sv);
                    XoaTrang();
                    MessageBox.Show("Đã xóa sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dgvsinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsinhvien.Rows[e.RowIndex];
                txtmasinhvien.Text = row.Cells["MaSV"].Value?.ToString();
                txttensinhvien.Text = row.Cells["TenSV"].Value?.ToString();
                cbgioitinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtnamsinh.Text = row.Cells["NamSinh"].Value?.ToString();
                txtsdt.Text = row.Cells["SDT"].Value?.ToString();
                txtdiachi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtlop.Text = row.Cells["Lop"].Value?.ToString();
                cbkhoa.Text = row.Cells["Khoa"].Value?.ToString();
            }
        }
        private void XoaTrang()
        {
            txtmasinhvien.Clear();
            txttensinhvien.Clear();
            txtnamsinh.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtlop.Clear();
            cbgioitinh.SelectedIndex = -1;
            cbkhoa.SelectedIndex = -1;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = btntimkiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvsinhvien.DataSource = dsSinhVien;
                return;
            }
            var ketQua = dsSinhVien
                .Where(sv => sv.MaSV.ToLower().Contains(tuKhoa)
                          || sv.TenSV.ToLower().Contains(tuKhoa)
                          || sv.Lop.ToLower().Contains(tuKhoa)
                          || sv.Khoa.ToLower().Contains(tuKhoa))
                .ToList();
            dgvsinhvien.DataSource = null;
            dgvsinhvien.DataSource = ketQua;

            if (ketQua.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên nào!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndanhsach_Click(object sender, EventArgs e)
        {
            dgvsinhvien.DataSource = null;
            dgvsinhvien.DataSource = dsSinhVien;

            MessageBox.Show("Đã hiển thị lại toàn bộ danh sách sinh viên!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
