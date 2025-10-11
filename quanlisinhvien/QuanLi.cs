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
    }
}
