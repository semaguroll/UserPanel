using CKFinder;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class Detail : System.Web.UI.Page
    {
        DetailData data = new DetailData();
        protected void Page_Load(object sender, EventArgs e)
        {

            ID = Request.QueryString["ID"];
            string op = Request.QueryString["op"];
            if (op == "delete")
            {
                data.SqlDelete(ID);
            }
            SqlDataReader dr = data.JoinData();
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}