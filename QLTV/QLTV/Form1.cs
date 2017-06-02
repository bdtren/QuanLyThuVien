using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThanhVien;

namespace QLTV
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void llbldangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            TaoTaiKhoan tao = new TaoTaiKhoan();
            tao.Activate();
            tao.ShowDialog(this);
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string strStatus = DocGia.KQDangNhap(txttaikhoan.Text, txtmatkhau.Text);
            if (strStatus == "error")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
            else if (txtxacthuc.Text != "3ufge")
                MessageBox.Show("Mã xác thực sai!");
            else
            {
                this.Hide();
                FormChinh chinh = new FormChinh(strStatus.Remove(2, 3).Trim());
                chinh.MdiParent = null;
                chinh.Activate();
                chinh.Show();
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string strStatus = DocGia.KQDangNhap(txttaikhoan.Text, txtmatkhau.Text);
                if (strStatus == "error")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
                else if (txtxacthuc.Text != "3ufge")
                    MessageBox.Show("Mã xác thực sai!");
                else
                {
                    this.Hide();
                    FormChinh chinh = new FormChinh(strStatus.Remove(2, 3).Trim());
                    chinh.MdiParent = null;
                    chinh.Activate();
                    chinh.Show();
                }
            }
        }
    }
}
