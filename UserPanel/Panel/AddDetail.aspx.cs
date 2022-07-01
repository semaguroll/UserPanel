using CKFinder;
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
    public partial class AddDetail : System.Web.UI.Page
    {
        DetailData data = new DetailData();       
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            data.SqlAdd(txtMenuId.Text, txtCK.Text);
            //this.Page_Load(sender, e);
             Response.Redirect("Detail.aspx");

        }
    }
}