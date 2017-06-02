using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;
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

        public DocGia(string strMaDocGia, string strGioiTinh, string strMSSV, string strHoTen, string strNgSinh, string strQueQuan, string strDiaChi, string strCMND, string strEmail, string strNgayTao, string strTenTK, string strMatKhau, string strSDT )
            : base(strHoTen, strGioiTinh, strNgSinh, strQueQuan, strDiaChi, strCMND, strEmail, strNgayTao, strTenTK, strMatKhau, strSDT)
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

        //lay ma doc gia cuoi cung 
        public static string MaCuoi()
        {
            string emp = null;
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConnectToSQL.ConnectionSQL;
            connect.Open();

            try
            {
                SqlCommand command = new SqlCommand("dbo.FuLayMaSo", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter result = new SqlParameter("@result", System.Data.SqlDbType.VarChar);
                result.Direction = System.Data.ParameterDirection.ReturnValue;

                command.Parameters.Add(result);

                command.ExecuteNonQuery();

                if (result.Value != DBNull.Value)
                {
                    emp = (string)result.Value;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally {
                connect.Close();
                connect.Dispose();
            }
            return emp;
        }

        //Kiem tra tai khoan mat khau co trong csdl khong
        public static string KQDangNhap(string taikhoan, string matkhau)
        {
            string emp = null;
            matkhau = GetMd5Hash(MD5.Create(), matkhau);
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = ConnectToSQL.ConnectionSQL;
            connect.Open();

            try
            {
                SqlCommand command = new SqlCommand("dbo.TonTaiTK", connect);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add("@TENTK", System.Data.SqlDbType.NVarChar).Value = taikhoan;
                command.Parameters.Add("@MATKHAU", System.Data.SqlDbType.NVarChar).Value = matkhau;

                SqlParameter result = new SqlParameter("@result", System.Data.SqlDbType.VarChar);
                result.Direction = System.Data.ParameterDirection.ReturnValue;

                command.Parameters.Add(result);

                command.ExecuteNonQuery();

                if (result.Value != DBNull.Value)
                {
                    emp = (string)result.Value;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connect.Close();
                connect.Dispose();
            }
            return emp;
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
                strMatKhau = GetMd5Hash(MD5.Create(), strMatKhau);
                p = new SqlParameter("@MATKHAU", strMatKhau);
                command.Parameters.Add(p);
                p = new SqlParameter("@SDT", strSDT);
                command.Parameters.Add(p);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            catch (Exception ex)
            {
                
            }
            connect.Close();
        }

        //chuyen ma sang md5
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

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
