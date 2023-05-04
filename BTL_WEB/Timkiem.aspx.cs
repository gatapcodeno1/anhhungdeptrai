using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Timkiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTen.InnerText = Session["Name"].ToString();
        }

        protected void find_Click(object sender, EventArgs e)
        {
            string nd = Request.Form["txtTimkiem"];
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            string inner = "";
            if (arr == null) { }
            else
            {
                int length = 0;
                foreach (Danhsachmon mon in arr)
                {
                    if (nd.ToLower() == mon.Des.ToLower() || nd.ToLower() == mon.Type.ToLower())
                    {
                        noidung.Visible = true;
                        inner += "<div class='category-content'><img src = " + mon.Img + " alt = '' class='category-img'/><p class='category-title'>" + mon.Des + "</p><a href = 'Chitietmonhoc.aspx?id=" + mon.ID + "&type=" + mon.Type + "'class='category-link'><button class='category-btn'>Học ngay</button></a></div>";
                        noidung.InnerHtml = inner;
                        none.Visible = false;
                        length++;
                    }

                }
                if (length == 0)
                {
                    none.Visible = true;
                    noidung.Visible = false;
                    string inner1 = "";
                    inner1 += "Không có kết quả mà bạn cần tìm";
                    none.InnerText = inner1;
                }
            }
        }
    }
}