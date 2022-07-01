using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using UserPanel.Panel;

namespace UserPanel.Data
{
    public class UserData : SqlConnect
    {
        SqlConnect conn = new SqlConnect();

        public SqlDataReader userdata()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Uye", conn.Connection());
            SqlDataReader uyedb = cmd.ExecuteReader();
            return uyedb;
        }
        public SqlDataReader GetLoginData(string eposta, string password)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Uye SET Eposta=@m3, Sifre=@m4 WHERE Eposta=@id", conn.Connection());
            cmd.Parameters.AddWithValue("@id", eposta);
            cmd.Parameters.AddWithValue("@m3", eposta);
            cmd.Parameters.AddWithValue("@m4", password);
            SqlDataReader uyedb = cmd.ExecuteReader();
            return uyedb;
        }
        public SqlDataReader GetDataByID(string ID)
        {
            SqlCommand com = new SqlCommand("SELECT * FROM tbl_Uye WHERE U_Id= @id", conn.Connection());

            com.Parameters.AddWithValue("@id", ID);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public void SqlUpdate(string id, string name, string surname, string eposta, string password)
        {
            var yenimail = GetDataByName(eposta);
            var eskimail = GetDataByID(id);            
            if (eskimail == yenimail)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Uye SET Ad=@m1,Soyad=@m2,Eposta=@m3, Sifre=@m4 WHERE U_Id=@id", conn.Connection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@m1", name);
                cmd.Parameters.AddWithValue("@m2", surname);
                cmd.Parameters.AddWithValue("@m3", eposta);
                cmd.Parameters.AddWithValue("@m4", password);
                cmd.ExecuteNonQuery();
                conn.Connection().Close();
            }

            else if (eskimail != yenimail)
            {
                if (!yenimail.HasRows)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Uye SET Ad=@m1,Soyad=@m2,Eposta=@m3, Sifre=@m4 WHERE U_Id=@id", conn.Connection());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@m1", name);
                    cmd.Parameters.AddWithValue("@m2", surname);
                    cmd.Parameters.AddWithValue("@m3", eposta);
                    cmd.Parameters.AddWithValue("@m4", password);
                    cmd.ExecuteNonQuery();
                    conn.Connection().Close();
                }
                else
                {
                    MessageBox.Show("Bu hesap daha önce eklenmiş.");
                }

            }

        }
        public string SqlUpdatebyMail(string onemli, string name, string surname, string eposta, string password)
        {
            //var eskimail = GetDataByName(onemli);
            string ret= onemli;
            var yenimail = GetDataByName(eposta);
            if (onemli == eposta)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Uye SET Ad=@m1,Soyad=@m2,Eposta=@m3, Sifre=@m4 WHERE Eposta=@eposta", conn.Connection());
                cmd.Parameters.AddWithValue("@eposta", onemli);
                cmd.Parameters.AddWithValue("@m1", name);
                cmd.Parameters.AddWithValue("@m2", surname);
                cmd.Parameters.AddWithValue("@m3", eposta);
                cmd.Parameters.AddWithValue("@m4", password);
                cmd.ExecuteNonQuery();
            }

            else if (onemli != eposta)
            {
                if (!yenimail.HasRows)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Uye SET Ad=@m1,Soyad=@m2,Eposta=@m3, Sifre=@m4 WHERE Eposta=@eposta", conn.Connection());
                    cmd.Parameters.AddWithValue("@eposta", onemli);
                    cmd.Parameters.AddWithValue("@m1", name);
                    cmd.Parameters.AddWithValue("@m2", surname);
                    cmd.Parameters.AddWithValue("@m3", eposta);
                    cmd.Parameters.AddWithValue("@m4", password);
                    cmd.ExecuteNonQuery();
                    ret= eposta;
                }
                else
                {
                    MessageBox.Show("Bu hesap daha önce eklenmiş.");
                }
               
            }
            return ret;
        }
        public void SqlDelete(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Uye WHERE U_Id = @id", conn.Connection());
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            conn.Connection().Close();
        }
        public void SqlAdd(string name, string surname, string eposta, string password)
        {
            var deneme = GetDataByName(eposta);
            if (!deneme.HasRows)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Uye (Ad,Soyad,Eposta,Sifre) VALUES (@un,@us,@ue,@up)", conn.Connection());
                cmd.Parameters.AddWithValue("@un", name);
                cmd.Parameters.AddWithValue("@us", surname);
                cmd.Parameters.AddWithValue("@ue", eposta);
                cmd.Parameters.AddWithValue("@up", password);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bu fotoğtaf daha önce eklenmiş.");
            }

        }
        public SqlDataReader GetDataByName(string eposta)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Uye WHERE Eposta= @eposta", conn.Connection());
            cmd.Parameters.AddWithValue("@eposta", eposta);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}