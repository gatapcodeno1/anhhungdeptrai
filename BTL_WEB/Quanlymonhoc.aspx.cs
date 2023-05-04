using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Quanlymonhoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTen.InnerText = Session["Name"].ToString();
            int i = 0;
            string inner1 = "";
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            foreach (Danhsachmon mon  in arr)
            {
                inner1 += "<tr onmouseover='moveTaget(this)' onmouseout='outTaget(this)' class='monhoc' data-value='" + mon.ID +"'>" +
                    "<td class='auto'>"+ (++i) +"</td>" +
                    "<td >"+ mon.Des +"</td>" +
                    "<td >" + mon.Type + "</td>" +
                    "<td class='nd'>" + mon.Detail + "</td>" +
                    "<td class='nd'>" + mon.Url + "</td>" +
                    "<td class='nd'>" + mon.Video + "</td>" +
                    "</tr>";    
            }
            noidung.InnerHtml = inner1;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            string name = Request.Form["txtName"];
            string nd = Request.Form["txtNoidung"];
            string tl = Request.Form["theloai"];
            string linkvid = Request.Form["txtLinkvid"];
            string linktk = Request.Form["txtLinktk"];
            string date = Request.Form["txtDate"];
            Random rn = new Random();
            int id = rn.Next(5, 9000);
            int number;
            if(name == "" || nd == "" || tl == "" || linkvid == "" || linktk == "" || int.TryParse(name, out number))
            {

            }
            else
            {
                int check = 0;
                foreach(Danhsachmon monhoc in arr)
                {
                    if(monhoc.Des == name)
                    {
                        check = 1;
                        string alert = "";
                        alert += "Môn học này đã có,mời nhập lại!";
                        tb.InnerText = alert;
                    }
                }
                if(check == 0)
                {
                    Danhsachmon mon = new Danhsachmon(id, "Img/interface-research.png", name, tl, nd, linktk, linkvid); 
                    arr.Add(mon);
                    Response.Redirect("Quanlymonhoc.aspx");
                }
            }
        }
        protected void edit_btn_Click(object sender, EventArgs e)
        {
            string id = Request.Form["id_monhoc"];
            string name = Request.Form["txtName"];
            string nd = Request.Form["txtNoidung"];
            String tl = Request.Form["theloai"];
            int i = Int32.Parse(id);
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            if (arr == null) { }
            else
            {
                foreach(Danhsachmon mon in arr)
                {
                    if(mon.ID == i)
                    {
                        mon.Des = name;
                        mon.Detail = nd;
                        mon.Type = tl;
                        break;
                    }
                }
                Response.Redirect("Quanlymonhoc.aspx");
            }
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            string id = Request.Form["id_monhoc"];
            int i = Int32.Parse(id);
            List<Danhsachmon> arr = (List<Danhsachmon>)Application["dsmon"];
            if(arr == null) { }
            else
            {
                arr.RemoveAll(r => r.ID == i);
                Response.Redirect("Quanlymonhoc.aspx");
            }           
        }
    }
}