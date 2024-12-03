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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        List<NhanVien> nv;
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien n = new NhanVien();
            if (n.ShowDialog() == DialogResult.OK)
            {

                dataGridView1.Rows.Add(n.ms,n.ten,n.luong);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("MSNV", "MSNV");
            dataGridView1.Columns.Add("TenNV", "Tên NV");
            dataGridView1.Columns.Add("LuongCB", "Lương CB");


            dataGridView1.Rows.Add("NV001", "Nguyễn Thị Diệu Hiền", 15000000);
            dataGridView1.Rows.Add("NV003", "Nguyễn Thị Thu Hiền", 500000);
            dataGridView1.Rows.Add("NV004", "Nguyễn Thị Hồng Thắm", 800000);
            dataGridView1.Rows.Add("NV005", "Huỳnh Gia Hân", 6500000);
            dataGridView1.Rows.Add("NV006", "Nguyễn Thị Thuý Vi", 7500000);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                string employeeID = selectedRow.Cells[0].Value.ToString();
                string employeeName = selectedRow.Cells[1].Value.ToString();
                string employeeSalary = selectedRow.Cells[2].Value.ToString();


                NhanVien nv = new NhanVien(employeeID, employeeName, employeeSalary);
                if (nv.ShowDialog() == DialogResult.OK)
                {

                    selectedRow.Cells[0].Value = nv.ms;
                    selectedRow.Cells[1].Value = nv.ten;
                    selectedRow.Cells[2].Value = nv.luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

