using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UserPanel.Panel;

namespace UserPanel.Data
{
    public class LoginData
    {
        SqlConnect conn = new SqlConnect();
        public SqlDataReader logindata( string eposta, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Uye WHERE Eposta=@m3 AND Sifre=@m4 ", conn.Connection());
            cmd.Parameters.AddWithValue("@m3",eposta);
            cmd.Parameters.AddWithValue("@m4", password);
            SqlDataReader uyedb = cmd.ExecuteReader();
            return uyedb;
        }
    }
}