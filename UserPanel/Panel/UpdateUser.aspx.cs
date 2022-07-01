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
    public partial class UpdateUser : System.Web.UI.Page
    {
        SqlConnect conn = new SqlConnect();
        UserData data = new UserData();
        string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            if (Page.IsPostBack == false)
            {
                SqlDataReader dr = data.GetDataByID(ID);
                while (dr.Read())
                {
                    txtName.Text = dr[1].ToString();
                    txtSurname.Text = dr[2].ToString();
                    txtEposta.Text = dr[3].ToString();
                    txtPassword.Text = dr[4].ToString();
                }
                conn.Connection().Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            data.SqlUpdate(ID, txtName.Text, txtSurname.Text, txtEposta.Text, txtPassword.Text);
            Response.Redirect("User.aspx");
        }
    }
}