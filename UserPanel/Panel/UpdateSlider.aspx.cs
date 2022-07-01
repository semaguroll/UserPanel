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
    public partial class UpdateSlider : System.Web.UI.Page
    {
        SliderData data = new SliderData();
        SqlConnect conn = new SqlConnect();
        string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ID = Request.QueryString["ID"];
            if (Page.IsPostBack == false)
            {
                SqlDataReader dr = data.GetDataByID(ID);
                while (dr.Read())
                {
                    txtName.Text = dr[1].ToString();
                    txtLink.Text = dr[3].ToString();
                }
                conn.Connection().Close();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string img = "/Images/" + imgSlider.FileName;
            imgSlider.SaveAs(Server.MapPath(img));
            data.SqlUpdate(ID, txtName.Text,img, txtLink.Text);
            Response.Redirect("Slider.aspx");
        }
    }
}