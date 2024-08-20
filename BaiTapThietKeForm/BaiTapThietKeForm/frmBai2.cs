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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void btnBohang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            //duyệt danh sách các mặt hàng đã mua nằm trong list box 2
            //Cộng dồn tiền cần thanh toán
            foreach(string hang in listBox2.Items)
            {
                switch(hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn Phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB":
                        soTien += 200000;
                        break;
                        default: 
                        break;
        //Tên hàng phải viết chính xác giống trong listboxx

                }
                lblSoTien.Text = soTien+"đồng";
                
            }    
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
