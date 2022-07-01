using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class UpdateDetail : System.Web.UI.Page
    {
        DetailData data = new DetailData();
        SqlConnect conn = new SqlConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            if (Page.IsPostBack == false)
            {
                SqlDataReader dr = data.GetDataByID(ID);
                while (dr.Read())
                {
                    txtMenuId.Text = dr[1].ToString();
                    txtCK.Text = dr[2].ToString();
                }
                conn.Connection().Close();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            data.SqlUpdate(ID, txtMenuId.Text, txtCK.Text);
            Response.Redirect("Detail.aspx");
        }
    }
}