using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UserPanel.Panel;

namespace UserPanel.Data
{
    public class DetailData
    {
        SqlConnect conn = new SqlConnect();

        public SqlDataReader detaildata()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Kurumsal", conn.Connection());
            SqlDataReader detaildb = cmd.ExecuteReader();
            return detaildb;
        }
        public SqlDataReader JoinData()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Kurumsal AS K INNER JOIN tbl_Menu AS M ON M.M_Id=K.MenuID", conn.Connection());
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public void SqlUpdate(string id,string menuid, string detay)
        {
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Kurumsal SET MenuId=@m1,Detay=@m2 WHERE K_Id=@id", conn.Connection());
            cmd.Parameters.AddWithValue("@id", id); 
            cmd.Parameters.AddWithValue("@m1", menuid);
            cmd.Parameters.AddWithValue("@m2", detay);
         
            cmd.ExecuteNonQuery();
            conn.Connection().Close();
        }
        public void SqlDelete(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Kurumsal WHERE K_Id = @id", conn.Connection());
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            conn.Connection().Close();
        }
        public void SqlAdd(string menuid, string detay)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Kurumsal (MenuId,Detay) VALUES (@un,@us)", conn.Connection());
            cmd.Parameters.AddWithValue("@un", menuid);
            cmd.Parameters.AddWithValue("@us", detay);
            cmd.ExecuteNonQuery();
        }
        public SqlDataReader GetDataByID(string ID)
        {
            SqlCommand com = new SqlCommand("SELECT * FROM tbl_Kurumsal WHERE K_Id= @id", conn.Connection());
            com.Parameters.AddWithValue("@id", Convert.ToInt32(ID));
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
    }
}