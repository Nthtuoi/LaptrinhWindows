using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_T5
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtLastName.Text);
            lv1.SubItems.Add(txtFirstName.Text);
            lv1.SubItems.Add(txtPhone.Text);

            lvHoTen.Items.Add(lv1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lvHoTen.SelectedItems.Count > 0) 
            {
                lvHoTen.Items.RemoveAt(lvHoTen.SelectedItems[0].Index);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvHoTen.SelectedItems.Count > 0)
            { 
                ListViewItem lv1 = lvHoTen.SelectedItems[0];
                lv1.SubItems[0].Text = txtLastName.Text;
                lv1.SubItems[1].Text = txtFirstName.Text;
                lv1.SubItems[2].Text = txtPhone.Text;   
            }
        }

        private void lvHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvHoTen.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = lvHoTen.SelectedItems[0];
                String LastName = lv1.SubItems[0].Text;
                String FirstName = lv1.SubItems[1].Text;
                String Phone = lv1.SubItems[2].Text;
                txtLastName.Text = LastName;
                txtFirstName.Text = FirstName;
                txtPhone.Text = Phone;
            }

        }
    }
}
