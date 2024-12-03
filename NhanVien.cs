using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class NhanVien : Form
    {
        public string ms { get; set; }
        public string ten { get; set; }
        public int luong { get; set; }
        public NhanVien(string MS = "", string Ten = "", string Luong = "0")
        {
            InitializeComponent();
            txtMsnv.Text = MS;
            txtTen.Text = Ten;
            txtLuong.Text = int.TryParse(Luong, out int parsedSalary) ? parsedSalary.ToString() : "0";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            ms = txtMsnv.Text;
            ten = txtTen.Text;
            if (int.TryParse(txtLuong.Text, out int Luong))
            {
                luong = Luong;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lương phải là một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
