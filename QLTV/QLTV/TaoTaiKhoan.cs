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
using System.Data.SqlClient;
using System.Security.Cryptography;

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
            string strHoTen ="", strGioiTinh = "Nam", strNgSinh = "", strQueQuan = "", strDiaChi = "", strCMND = "",
                strEmail = "", strNgayTao = "", strTenTK = "", strMatKhau = "", strMaDocGia = "", strMSSV = "", strSDT = "";
            try
            {
                strHoTen = txtHoten.Text;
                strNgSinh = dtmNgaysinh.Text;
                strQueQuan = txtQueQuan.Text;
                strDiaChi = txtDiaChi.Text;
                strCMND = txtCMND.Text;
                strEmail = txtEmail.Text;
                strSDT = txtSDT.Text;
                strTenTK = txtTK.Text;
                strMatKhau = txtMatKhau.Text;
                strMSSV = txtMSSV.Text;
            }
            catch
            {

            }
            if (strHoTen == "" || strNgSinh == "" || strQueQuan == ""|| strDiaChi == "" || strCMND == "" || 
                strEmail == "" || strNgayTao == "" || strTenTK == "" || strMatKhau == "" || strMaDocGia == "" ||
                strMSSV == "" || strSDT == "")
            {
                MessageBox.Show(this, "Nhập không đúng, yêu cầu nhập lại!", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
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
            strSDT = txtSDT.Text;
            strTenTK = txtTK.Text;
            strMatKhau = txtMatKhau.Text;
            strMSSV = txtMSSV.Text;

            for (int i = 0; i < strCMND.Length; i++)
            {
                if (!(strCMND[i] >= '0' && strCMND[i] <= '9'))
                {
                    MessageBox.Show("So CMND khong hop le");
                    return;
                }
            }
            for (int i = 0; i < strMSSV.Length; i++)
            {
                if (!(strMSSV[i] >= '0' && strMSSV[i] <= '9'))
                {
                    MessageBox.Show("MSSV khong hop le");
                    return;
                }
            }
            strMaDocGia =  DocGia.MaCuoi().Remove(2,3);
            int temp1 = int.Parse(DocGia.MaCuoi().Remove(0, 2));
            temp1++;
            string temp2 = "";
            if (temp1 < 10)
                temp2 = "00" + temp1;
            else if (temp1 < 100 && temp1 > 9)
                temp2 = "0" + temp1;
            else temp2 += temp1;
            strMaDocGia = strMaDocGia.Trim();
            strMaDocGia += temp2;
            
            strNgayTao = DateTime.Now.ToString();
            DocGia dg = new DocGia(strMaDocGia, strGioiTinh, strMSSV, strHoTen, strNgSinh,
               strQueQuan, strDiaChi, strCMND, strEmail, strNgayTao, strTenTK, strMatKhau,strSDT);
            dg.Nhap();
            MessageBox.Show(this, "Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
            cboQQTinh.Items.Add("Hồ Chí Minh");
            cboQQTinh.Items.Add("Hà Nội");
            cboDCTinh.Items.Add("Hồ Chí Minh");
            cboDCTinh.Items.Add("Hà Nội");

        }

        private void cboQQTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboQQTinh.SelectedIndex)
            {
                case 0:
                    cboQQHuyen.Items.Clear();
                    cboQQXa.Items.Clear();
                    string[] st1 = new string[] { "Quan 1", "Quan 12", "Quan Thu Duc", "Quan 9", "Quan 10" };
                    cboQQHuyen.Items.AddRange(st1);
                    break;
                case 1:
                    cboQQHuyen.Items.Clear();
                    cboQQXa.Items.Clear();
                    string[] st2 = new string[] { "Quan Ba Dinh", "Quan Tay Ho", "Quan Dong Da", "Quan Long Bien", "Quan Cau Giay" };
                    cboQQHuyen.Items.AddRange(st2);
                    break;
            }
        }


        private void cboQQHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboQQTinh.SelectedIndex == 0)
            {
                switch (cboQQHuyen.SelectedIndex)
                {
                    case 0:
                        cboQQXa.Items.Clear();
                        string[] st1 = new string[] { "Phuong Tan dinh", "Phuong Ben Nghe", "Phuong Ben Thanh", "Phuong Co Giang", "Phuong Cau Kho" };
                        cboQQXa.Items.AddRange(st1);
                        break;
                    case 1:
                        cboQQXa.Items.Clear();
                        string[] st2 = new string[] { "Phuong Thanh Xuan", "Phuong Thanh Loc", "Phuong Hiep Thanh", "Phuong Thoi An", "Phuong An Phu Dong" };
                        cboQQXa.Items.AddRange(st2);
                        break;
                    case 2:
                        cboQQXa.Items.Clear();
                        string[] st3 = new string[] { "Phuong Linh Xuan", "Phuong Binh Chieu", "Phuong Linh Trung", "Phuong Tam Binh", "Phuong Tam Phu" };
                        cboQQXa.Items.AddRange(st3);
                        break;
                    case 3:
                        cboQQXa.Items.Clear();
                        string[] st4 = new string[] { "Phuong Long Binh", "Phuong Long Phu", "Phuong Phuoc Long A", "Phuong Phuoc Long B", "Phuong Phu Huu" };
                        cboQQXa.Items.AddRange(st4);
                        break;
                    case 4:
                        cboQQXa.Items.Clear();
                        string[] st5 = new string[] { "Phuong 1", "Phuong 2", "Phuong 3", "Phuong 4", "Phuong 5" };
                        cboQQXa.Items.AddRange(st5);
                        break;
                }
            }
            if (cboQQTinh.SelectedIndex == 1)
            {
                switch (cboQQHuyen.SelectedIndex)
                {
                    case 0:
                        cboQQXa.Items.Clear();
                        string[] st1 = new string[] { "Phuong Truc Xa", "Phuong Truc Bach", "Phuong Vinh Phuc", "Phuong Cong Vi", "Phuong Ngoc Ha" };
                        cboQQXa.Items.AddRange(st1);
                        break;
                    case 1:
                        cboQQXa.Items.Clear();
                        string[] st2 = new string[] { "Phuong Buoi", "Phuong Yen Phu", "Phuong Xuan La", "Phuong Quan An", "Phuong Tu Lien" };
                        cboQQXa.Items.AddRange(st2);
                        break;
                    case 2:
                        cboQQXa.Items.Clear();
                        string[] st3 = new string[] { "Phuong Cat Linh", "Phuong Quoc Tu Giam", "Phuong Van Mieu", "Phuong Hang Bot", "Phuong Kiem Lien" };
                        cboQQXa.Items.AddRange(st3);
                        break;
                    case 3:
                        cboQQXa.Items.Clear();
                        string[] st4 = new string[] { "Phuong Thuong Thanh", "Phuong Ngoc Thuy", "Phuong Giang Bien", "Phuong Long Bien", "Phuong Phuc Dong" };
                        cboQQXa.Items.AddRange(st4);
                        break;
                    case 4:
                        cboQQXa.Items.Clear();
                        string[] st5 = new string[] { "Phuong Nghia Do", "Phuong Nghia Tan", "Phuong Mai Dich", "Phuong Dich Vong", "Phuong Yen Hoa" };
                        cboQQXa.Items.AddRange(st5);
                        break;


                }
            }
        }

        private void cboDCTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDCTinh.SelectedIndex)
            {
                case 0:
                    cboDCHuyen.Items.Clear();
                    cboDCXa.Items.Clear();
                    string[] st1 = new string[] { "Quan 1", "Quan 12", "Quan Thu Duc", "Quan 9", "Quan 10" };
                    cboDCHuyen.Items.AddRange(st1);
                    break;
                case 1:
                    cboDCHuyen.Items.Clear();
                    cboDCXa.Items.Clear();
                    string[] st2 = new string[] { "Quan Ba Dinh", "Quan Tay Ho", "Quan Dong Da", "Quan Long Bien", "Quan Cau Giay" };
                    cboDCHuyen.Items.AddRange(st2);
                    break;

            }
        }

        private void cboDCHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDCTinh.SelectedIndex == 0)
            {
                switch (cboDCHuyen.SelectedIndex)
                {
                    case 0:
                        cboDCXa.Items.Clear();
                        string[] st1 = new string[] { "Phuong Tan dinh", "Phuong Ben Nghe", "Phuong Ben Thanh", "Phuong Co Giang", "Phuong Cau Kho" };
                        cboDCXa.Items.AddRange(st1);
                        break;
                    case 1:
                        cboDCXa.Items.Clear();
                        string[] st2 = new string[] { "Phuong Thanh Xuan", "Phuong Thanh Loc", "Phuong Hiep Thanh", "Phuong Thoi An", "Phuong An Phu Dong" };
                        cboDCXa.Items.AddRange(st2);
                        break;
                    case 2:
                        cboDCXa.Items.Clear();
                        string[] st3 = new string[] { "Phuong Linh Xuan", "Phuong Binh Chieu", "Phuong Linh Trung", "Phuong Tam Binh", "Phuong Tam Phu" };
                        cboDCXa.Items.AddRange(st3);
                        break;
                    case 3:
                        cboDCXa.Items.Clear();
                        string[] st4 = new string[] { "Phuong Long Binh", "Phuong Long Phu", "Phuong Phuoc Long A", "Phuong Phuoc Long B", "Phuong Phu Huu" };
                        cboDCXa.Items.AddRange(st4);
                        break;
                    case 4:
                        cboDCXa.Items.Clear();
                        string[] st5 = new string[] { "Phuong 1", "Phuong 2", "Phuong 3", "Phuong 4", "Phuong 5" };
                        cboDCXa.Items.AddRange(st5);
                        break;
                }
            }
            if (cboDCTinh.SelectedIndex == 1)
            {
                switch (cboDCHuyen.SelectedIndex)
                {
                    case 0:
                        cboDCXa.Items.Clear();
                        string[] st1 = new string[] { "Phuong Truc Xa", "Phuong Truc Bach", "Phuong Vinh Phuc", "Phuong Cong Vi", "Phuong Ngoc Ha" };
                        cboDCXa.Items.AddRange(st1);
                        break;
                    case 1:
                        cboDCXa.Items.Clear();
                        string[] st2 = new string[] { "Phuong Buoi", "Phuong Yen Phu", "Phuong Xuan La", "Phuong Quan An", "Phuong Tu Lien" };
                        cboDCXa.Items.AddRange(st2);
                        break;
                    case 2:
                        cboDCXa.Items.Clear();
                        string[] st3 = new string[] { "Phuong Cat Linh", "Phuong Quoc Tu Giam", "Phuong Van Mieu", "Phuong Hang Bot", "Phuong Kiem Lien" };
                        cboDCXa.Items.AddRange(st3);
                        break;
                    case 3:
                        cboDCXa.Items.Clear();
                        string[] st4 = new string[] { "Phuong Thuong Thanh", "Phuong Ngoc Thuy", "Phuong Giang Bien", "Phuong Long Bien", "Phuong Phuc Dong" };
                        cboDCXa.Items.AddRange(st4);
                        break;
                    case 4:
                        cboDCXa.Items.Clear();
                        string[] st5 = new string[] { "Phuong Nghia Do", "Phuong Nghia Tan", "Phuong Mai Dich", "Phuong Dich Vong", "Phuong Yen Hoa" };
                        cboDCXa.Items.AddRange(st5);
                        break;


                }
            }
        }

        private void cboQQXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQueQuan.Text = cboQQXa.Text + " " + cboQQHuyen.Text + " " + cboQQTinh.Text;

        }

        private void cboDCXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = cboDCXa.Text + " " + cboDCHuyen.Text + " " + cboDCTinh.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoten.Text = dtmNgaysinh.Text = txtQueQuan.Text = txtDiaChi.Text = txtCMND.Text 
                = txtEmail.Text = txtSDT.Text = txtTK.Text = txtMatKhau.Text = txtMSSV.Text = "";
        }
    }
}
