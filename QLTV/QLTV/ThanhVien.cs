using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTV;
using System.Data.SqlClient;
using System.Data.Common;


namespace ThanhVien
{
    public abstract class ThanhVien
    {
        protected string strHoTen, strGioiTinh, strNgSinh, strQueQuan, strDiaChi, 
            strCMND, strEmail, strNgayTao, strTenTK, strMatKhau, strSDT;

        public ThanhVien()
        {
            strHoTen = null;
            strGioiTinh = "Nam";
            strNgSinh = null;
            strQueQuan = null;
            strDiaChi = null;
            strCMND = null;
            strEmail = null;
            strNgayTao = null;
            strTenTK = null;
            strMatKhau = null;
            strSDT = null;
        }

        public ThanhVien(string strHoTen, string strGioiTinh, string strNgSinh, string strQueQuan, string strDiaChi, string strCMND, string strEmail, string strNgayTao, string strTenTK, string strMatKhau, string strSDT)
        {
            this.strHoTen = strHoTen;
            this.strNgSinh = strNgSinh;
            this.strGioiTinh = strGioiTinh;
            this.strNgayTao = strNgayTao;
            this.strQueQuan = strQueQuan;
            this.strDiaChi = strDiaChi;
            this.strCMND = strCMND;
            this.strEmail = strEmail;
            this.strTenTK = strTenTK;
            this.strMatKhau = strMatKhau;
            this.strSDT = strSDT;
        }

        public string HOTEN
        {
            get { return strHoTen; }
            set { strHoTen = value; }
        }
        public string GIOITINH
        {
            get { return strGioiTinh; }
            set { strGioiTinh = value; }
        }
        public string NGSINH
        {
            get { return strNgSinh; }
            set { strNgSinh = value; }
        }

        public string QUEQUAN
        {
            get { return strQueQuan; }
            set { strQueQuan = value; }
        }

        public string DIACHI
        {
            get { return strDiaChi; }
            set { strDiaChi = value; }
        }

        public string CMND
        {
            get { return strCMND; }
            set { strCMND = value; }
        }

        public string EMAIL
        {
            get { return strEmail; }
            set { strEmail = value; }
        }

        public string NGAYTAO
        {
            get { return strNgayTao; }
            set { strNgayTao = value; }
        }
        public string TENTK
        {
            get { return strTenTK; }
            set { strTenTK = value; }
        }

        public string MATKHAU
        {
            get { return strMatKhau; }
            set { strMatKhau = value; }
        }

        protected string StrSDT { get { return strSDT; }
            set { strSDT = value; } }

        ////////////////////
        ///// có hay không hai hàm nhập xuất đang còn phân vân 
        ///vì trên form thao tác với textBox nên sử dụng get set cho tiện;

        public void Nhap()
        {
            
        }

        public void Xuat()
        {

        }        

    }

}
