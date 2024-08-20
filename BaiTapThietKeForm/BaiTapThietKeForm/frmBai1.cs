using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "50000";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "60000";
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "70000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lbISoTien.Text=soTien.ToString();
        }
    }
}
