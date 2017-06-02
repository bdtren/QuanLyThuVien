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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string strHoTen, strGioiTinh = "Nam", strNgSinh, strQueQuan, strDiaChi, strCMND, strEmail, strNgayTao, strTenTK, strMatKhau, strMaDocGia, strMSSV;
            try
            {
                strHoTen = txtHoten.Text;
                strNgSinh = dtmNgaysinh.Text;
                strQueQuan = txtQueQuan.Text;
                strDiaChi = txtDiaChi.Text;
                strCMND = txtCMND.Text;
                strEmail = txtEmail.Text;
               
                strTenTK = txtTK.Text;
                strMatKhau = txtMatKhau.Text;
                strMSSV = txtMSSV.Text;

            }
            catch
            {

            }
            if (rdoNu.Checked == true)
            {
                strGioiTinh = "Nu";
            }
            strHoTen = txtHoten.Text;
            strNgSinh = dtmNgaysinh.Text;
            strQueQuan = txtQueQuan.Text;
            strDiaChi = txtDiaChi.Text;
            strCMND = txtCMND.Text;
            strEmail = txtEmail.Text;
            
            strTenTK = txtTK.Text;
            strMatKhau = txtMatKhau.Text;
            strMSSV = txtMSSV.Text;
            strMaDocGia = "DG001";
            strNgayTao = DateTime.Now.ToString();
            DocGia dg = new DocGia(strMaDocGia, strGioiTinh, strMSSV, strHoTen, strNgSinh, strQueQuan, strDiaChi, strCMND, strEmail, strNgayTao, strTenTK, strMatKhau);
            MessageBox.Show(dg.MADOCGIA+"  "+dg.HOTEN);
            //dg.Nhap();
        }
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
        }
    }
}
