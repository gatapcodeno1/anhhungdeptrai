using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Trangchu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inner = "";
            txtTen.InnerText = Session["Name"].ToString();
            if((string)Session["Doituong"] == "Giáo viên")
            {
                inner += "<li class='nav__item'><a href='Quanlymonhoc.aspx' class='nav__link'>Thêm bài giảng</a></li>";
            }
            nav.InnerHtml = inner;

            //Render môn học
            string inner1 = "";
            string inner2 = "";
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            foreach(Danhsachmon mon in arr)
            {
                if(mon.Type == "môn chính")
                {
                    inner1 += "<div class='category-content'><img src = " + mon.Img + " alt = '' class='category-img'/><p class='category-title'>" + mon.Des + "</p><a href = 'Chitietmonhoc.aspx?id=" + mon.ID + "&type=" + mon.Type + "'class='category-link'><button class='category-btn'>Học ngay</button></a></div>";
                }else if(mon.Type == "môn phụ")
                {
                    inner2 += "<div class='category-content'><img src = " + mon.Img + " alt = '' class='category-img'/><p class='category-title'>" + mon.Des + "</p><a href = 'Chitietmonhoc.aspx?id=" + mon.ID + "&type=" + mon.Type + "' class='category-link'><button class='category-btn'>Học ngay</button></a></div>";
                }
            }
            monhoc.InnerHtml = inner1;
            monphu.InnerHtml = inner2;

            sl.InnerText = sl.InnerText + Application["Khachtruycap"].ToString();

        }
    }
}