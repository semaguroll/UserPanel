using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using UserPanel.Panel;

namespace UserPanel.Data
{
    public class SliderData
    {
        SqlConnect conn = new SqlConnect();

        public SqlDataReader sliderdata()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Slider", conn.Connection());
            SqlDataReader sliderdb = cmd.ExecuteReader();
            return sliderdb;
        }
        public void SqlUpdate(string id, string ad, string url, string link)
        {
            var deneme = GetDataByName(url);
            if (!deneme.HasRows)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Slider SET GorselAdi=@m1,GorselUzantisi=@m2,Link=@m3 WHERE S_Id=@id", conn.Connection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@m1", ad);
                cmd.Parameters.AddWithValue("@m2", url);
                cmd.Parameters.AddWithValue("@m3", link);
                cmd.ExecuteNonQuery();
                conn.Connection().Close();
            }
            else
            {
                MessageBox.Show("Bu fotoğtaf daha önce eklenmiş.");
            }
           
        }
        public void SqlDelete(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Slider WHERE S_Id = @id", conn.Connection());
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            conn.Connection().Close();
        }
        public void SqlAdd(string ad, string url, string link)
        {
            var deneme = GetDataByName(url);
            if (!deneme.HasRows)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Slider (GorselAdi,GorselUzantisi,Link) VALUES (@un,@us,@ue)", conn.Connection());
                cmd.Parameters.AddWithValue("@un", ad);
                cmd.Parameters.AddWithValue("@us", url);
                cmd.Parameters.AddWithValue("@ue", link);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bu fotoğtaf daha önce eklenmiş.");
            }
            
        }
        public SqlDataReader GetDataByID(string ID)
        {            
            SqlCommand com = new SqlCommand("SELECT * FROM tbl_Slider WHERE S_Id= @id", conn.Connection());

            com.Parameters.AddWithValue("@id", ID);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public SqlDataReader GetDataByName(string url)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Slider WHERE GorselUzantisi= @Url", conn.Connection());

            cmd.Parameters.AddWithValue("@Url", url);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}