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
    public partial class Menu : System.Web.UI.Page
    {
        MenuData data = new MenuData();
        string Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["ID"];
            string op = Request.QueryString["op"];
            if (op == "delete")
            {
                data.SqlDelete(Id);
            }
            DataList1.DataSource = data.menudata();
            DataList1.DataBind();
            if (Session["kullanici"] != null)
            {
                Response.Write("Hoşgeldin " + Session["kullanici"]);
            }
        }

    }
}