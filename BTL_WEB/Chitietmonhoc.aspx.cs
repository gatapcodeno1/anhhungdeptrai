using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Chitietmonhoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inner = "";
            txtTen.InnerText = Session["Name"].ToString();
            if ((string)Session["Doituong"] == "Giáo viên")
            {
                inner += "<li class='nav__item'><a href='Quanlymonhoc.aspx' class='nav__link'>Thêm bài giảng</a></li>";
            }
            nav.InnerHtml = inner;

            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("Trangchu.aspx");
            }
            else
            {
                List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
                foreach(Danhsachmon mon in arr)
                {
                    if(mon.ID.ToString() == Request.QueryString["id"] && Request.QueryString["type"] == mon.Type.ToString())
                    {
                        name.Text = mon.Des;
                        img.ImageUrl = mon.Img;
                        detail.Text = mon.Detail;
                        video.Src = mon.Video;
                        link.NavigateUrl = mon.Url;
                    }
                }
            }
        }
    }
}