using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserPanel.Data;

namespace UserPanel.Panel
{
    public partial class AddSlider : System.Web.UI.Page
    {
        SliderData data = new SliderData();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            imgSlider.SaveAs(Server.MapPath("/Images/" + imgSlider.FileName));
            data.SqlAdd(txtName.Text, "/Images/" + imgSlider.FileName, txtLink.Text);
            Response.Redirect("Slider.aspx");
        }
    }
}