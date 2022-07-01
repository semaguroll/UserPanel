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
    public partial class AddMenu : System.Web.UI.Page
    {
        MenuData data = new MenuData();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataList1.DataSource = data.menudata();
            DataList1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            data.SqlAdd(txtMenu.Text,txtUstID.Text,txtRoute.Text);
            Response.Redirect("Menu.aspx");
        }

        //protected void btnDelete_Click(object sender, EventArgs e)
        //{
        //    SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Menu WHERE MenuAdi = @ad", conn.Connection());
        //    cmd.Parameters.AddWithValue("@ad", txtMenu.Text);
        //    cmd.ExecuteNonQuery();
        //    data.Connection().Close();
          
        //}
    }
}