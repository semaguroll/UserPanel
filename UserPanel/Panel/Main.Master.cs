using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserPanel.Panel
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // var lb = this.Master.Session["kullanici"];
            string op = Request.QueryString["op"];
            if (op == "logout")
            {
                Session.Clear();
            }
        }

    }
}