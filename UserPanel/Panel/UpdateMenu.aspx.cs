using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class UpdateMenu : System.Web.UI.Page
    {
        SqlConnect conn = new SqlConnect();
        MenuData data = new MenuData();
        string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            if (Page.IsPostBack == false)
            {
                SqlDataReader dr = data.GetDataByID(ID);
               

                while (dr.Read())
                {
                    txtMenu.Text = dr[1].ToString();
                    txtUstMenu.Text = dr[2].ToString();
                    txtRoute.Text = dr[3].ToString();
                }
                conn.Connection().Close();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            data.SqlUpdate(ID, txtMenu.Text, txtUstMenu.Text, txtRoute.Text);
            Response.Redirect("Menu.aspx");
        }
    }
}