using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class Slider : System.Web.UI.Page
    {

        SliderData data = new SliderData();
        string Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["ID"];
            string op = Request.QueryString["op"];
            if (op == "delete")
            {
                data.SqlDelete(Id);
            }
            DataList1.DataSource = data.sliderdata();
            DataList1.DataBind();
        }
    }
}