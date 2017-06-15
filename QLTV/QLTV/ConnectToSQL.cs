using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    public static class ConnectToSQL
    {
        // public static string ConnectionSQL = @"Data Source=DESKTOP-I3OG0V3\SQLEXPRESS;Initial Catalog=QuanLyThuVien;" + "Integrated Security=True";
        public static string ConnectionSQL = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Projects\CSharp\QLTV\QLTV\bin\QuanLyThuVien.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
