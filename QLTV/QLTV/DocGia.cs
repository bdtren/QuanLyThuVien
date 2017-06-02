using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLTV;


namespace ThanhVien
{
    public class DocGia : ThanhVien
    {
        private string strMaDocGia,strMSSV;
        public DocGia() : base()
        {
            strMaDocGia = null;
            strMSSV = null;
        }

        public DocGia(string strMaDocGia, string strGioiTinh, string strMSSV, string strHoTen, string strNgSinh, string strQueQuan, string strDiaChi, string strCMND, string strEmail, string strNgayTao, string strTenTK, string strMatKhau ): base(strHoTen, strGioiTinh, strNgSinh, strQueQuan, strDiaChi, strCMND, strEmail, strNgayTao, strTenTK, strMatKhau)
        {
            this.strMaDocGia = strMaDocGia;
            this.strMSSV = strMSSV;
        }

        public string MADOCGIA
        {
            get { return strMaDocGia; }
            set { strMaDocGia=value; }
        }

        public string MSSV
        {
            get { return strMSSV; }
            set { strMSSV = value; }
        }
        public void Nhap()
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConnectToSQL.ConnectionSQL;
            connect.Open();
            SqlCommand command = new SqlCommand("dbo.ThemDocGia", connect);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter p;
            try
            {
                p = new SqlParameter("@MaDOCGIA", strMaDocGia);
                command.Parameters.Add(p);
                p = new SqlParameter("@HOTEN", strHoTen);
                command.Parameters.Add(p);
                p = new SqlParameter("@NGAYSINH", strNgSinh);
                command.Parameters.Add(p);
                p = new SqlParameter("@QUEQUAN", strQueQuan);
                command.Parameters.Add(p);
                p = new SqlParameter("@DIACHI", strDiaChi);
                command.Parameters.Add(p);
                p = new SqlParameter("@CMNN", strCMND);
                command.Parameters.Add(p);
                p = new SqlParameter("@MSSV", strMSSV);
                command.Parameters.Add(p);
                p = new SqlParameter("@Email", strEmail);
                command.Parameters.Add(p);
                p = new SqlParameter("@TENTKDG", strTenTK);
                command.Parameters.Add(p);
                p = new SqlParameter("@GIOITINH", strGioiTinh);
                command.Parameters.Add(p);
                p = new SqlParameter("@NGAYTAO", strNgayTao);
                command.Parameters.Add(p);
                p = new SqlParameter("@MATKHAU", strMatKhau);
                command.Parameters.Add(p);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                
            }
            connect.Close();
        }
    }
}
