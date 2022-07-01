using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserPanel.Panel
{
    public class SqlConnect
    {
        //string connectionstring = "Data Source:.; Initial Catalog:Dbo_UserPanel;Integrated Security:True;";
        public SqlConnection Connection()
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-U9AH93VF; Initial Catalog=Dbo_UserPanel;Integrated Security=True;");
            sql.Open();
            return sql;
        } 
    }
}