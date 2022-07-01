using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class Login1 : System.Web.UI.Page
    {
        LoginData data = new LoginData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader uyedb = data.logindata(txtEposta.Text,txtPassword.Text);
            if (uyedb.Read())
            {
                //Session.Add("kullanici", txtEposta.Text);
                Session.Add("kullanici", uyedb[1].ToString() + " " + uyedb[2].ToString());
                Session.Add("Kullanicimail", uyedb[3].ToString());
                Response.Redirect("Menu.aspx");
            }
            else
            {
                MessageBox.Show("E-posta veya şifre yanlış. Lütfen tekrar deneyiniz...");
                this.Page_Load(sender, e);
            }
        }
    }
}