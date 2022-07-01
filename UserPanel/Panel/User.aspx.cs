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
    public partial class User : System.Web.UI.Page
    {
        UserData data = new UserData();
        string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            string op = Request.QueryString["op"];
            if (op == "delete")
            {
                data.SqlDelete(ID);
            }
            DataList1.DataSource = data.userdata();
            DataList1.DataBind();
        }
    }

}
