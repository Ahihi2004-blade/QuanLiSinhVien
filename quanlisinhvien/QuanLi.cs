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
    public partial class QuanLi : Form
    {
        public QuanLi()
        {
            InitializeComponent();
        }

        private void btnqlsv_Click(object sender, EventArgs e)
        {
            QuanLiSinhVien f = new QuanLiSinhVien();
            f.ShowDialog();
        }

        private void btnquanlidiem_Click(object sender, EventArgs e)
        {
            QuanLiDiem f = new QuanLiDiem();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DiemRenLuyen frm = new DiemRenLuyen();
            frm.Show();
        }
    }
}
