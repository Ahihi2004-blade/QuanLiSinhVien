using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlisinhvien
{
    public partial class QuanLiDiem : Form
    {
        public QuanLiDiem()
        {
            InitializeComponent();
        }

        private void QuanLiDiem_Load(object sender, EventArgs e)
        {
            string[] gradingScale = { "A", "B+", "B", "C+", "C", "D+", "D", "F" };
            cmbxephang.Items.AddRange(gradingScale);
            comboBox2.Items.Add("Đặt mục tiêu");
            comboBox2.Items.Add("Bằng khá");
            comboBox2.Items.Add("Bằng giỏi");
            comboBox2.Items.Add("Bằng xuất sắc");

            comboBox2.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGoal = comboBox2.SelectedItem.ToString();
           

        }
    }
}

