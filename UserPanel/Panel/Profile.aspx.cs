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
    public partial class Profile : System.Web.UI.Page
    {
        UserData data = new UserData();
        SqlConnect conn = new SqlConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
       
            if (Page.IsPostBack == false)
            {
                SqlDataReader dr = data.GetDataByName(Session["kullanicimail"].ToString());
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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            var mail = data.SqlUpdatebyMail(Session["kullanicimail"].ToString(),txtName.Text, txtSurname.Text, txtEposta.Text, txtPassword.Text);
            Session.Add("kullanicimail",mail);
            Response.Redirect("User.aspx");
        }
    }
}