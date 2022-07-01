using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using UserPanel.Models;
using UserPanel.Panel;

namespace UserPanel.Data
{
    public class MenuData : SqlConnect
    {
        SqlConnect conn = new SqlConnect();

        public SqlDataReader menudata()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Menu", conn.Connection());
            SqlDataReader menudb = cmd.ExecuteReader();
            return menudb;
        }
        public SqlDataReader GetDataByID(string ID)
        {
            SqlCommand com = new SqlCommand("SELECT * FROM tbl_Menu WHERE M_Id= @id", conn.Connection());
            com.Parameters.AddWithValue("@id", ID);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
        }
        public void SqlDelete(string ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Menu WHERE M_Id = @ID", conn.Connection());
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.ExecuteNonQuery();
            conn.Connection().Close();

        }
        public void SqlAdd(string menu, string ustmenu, string route)
        {
            var deneme = GetDataByName(menu);
            if (!deneme.HasRows)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Menu (MenuAdi,UstMenuID,Route) VALUES (@m1,@m2,@m3)", conn.Connection());
                cmd.Parameters.AddWithValue("@m1", menu);
                cmd.Parameters.AddWithValue("@m2", ustmenu);
                cmd.Parameters.AddWithValue("@m3", route);
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Bu menü daha önce eklenmiş.");
            }
        }
        public void SqlUpdate(string id, string menu, string ustmenu, string route)
        {
            var deneme = GetDataByName(menu);
            if (!deneme.HasRows)
            {
                SqlCommand cmd = new SqlCommand("UPDATE tbl_Menu SET MenuAdi=@m1,UstMenuID=@m2,Route=@m3 WHERE M_Id=@id", conn.Connection());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@m1", menu);
                cmd.Parameters.AddWithValue("@m2", ustmenu);
                cmd.Parameters.AddWithValue("@m3", route);
                cmd.ExecuteNonQuery();
                conn.Connection().Close();
            }
            else
            {
                MessageBox.Show("Bu menü daha önce eklenmiş.");
            }

        }
        public SqlDataReader GetDataByName(string menuadi)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Menu WHERE MenuAdi= @MenuAdi", conn.Connection());

            cmd.Parameters.AddWithValue("@MenuAdi", menuadi);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


    }
}

