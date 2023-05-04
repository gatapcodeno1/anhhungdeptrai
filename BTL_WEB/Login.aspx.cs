using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["login"] = false;
            Session["id"] = "";
            Session["email"] = "";
            Session["Name"] = "";
            Session["Pass"] = "";
            Session["Doituong"] = "";


            if (Request.Form["btnLogin"] == "true")
            {
                List<Member> list = (List<Member>)Application["dsmem"];
                Member mb = new Member();
                mb.ID = list.Count;
                mb.Email = Request.Form["txtName_log"];
                mb.Pass1 = Request.Form["txtPass_log"];

                bool checktrung = false;
                foreach (Member mem in list)
                {
                    if (mem.Email == mb.Email && mem.Pass1 == mb.Pass1)
                    {
                        checktrung = true;
                        mb.ID = mem.ID;
                        mb.Ten = mem.Ten;
                        mb.Doituong = mem.Doituong;
                        break;
                    }
                }
                Application["dsmem"] = list;
                if (checktrung == false)
                {
                    string alert = "";
                    alert += "<script>alert('Tài khoản hoặc mật khẩu không đúng!');</script>";
                    Response.Write(alert);
                }
                else
                {
                    // Tạo session
                    Session["login"] = true;
                    Session["id"] = mb.ID;
                    Session["email"] = mb.Email;
                    Session["Name"] = mb.Ten;
                    Session["Pass"] = mb.Pass1;
                    Session["Doituong"] = mb.Doituong;
                    Response.Redirect("Trangchu.aspx");
                }
            }
        }
    }
}