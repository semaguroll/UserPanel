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
    public partial class AddUser : System.Web.UI.Page
    {
        UserData data = new UserData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            data.SqlAdd(txtName.Text, txtSurname.Text, txtEposta.Text, txtPassword.Text);
            Response.Redirect("User.aspx");
        }
    }
}