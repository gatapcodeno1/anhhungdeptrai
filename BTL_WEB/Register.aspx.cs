using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_WEB
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string path = "listMember.xml";

            if (Request.Form["btnRegist"] == "true")
            {
                List<Member> members = new List<Member>();

                if (File.Exists(Server.MapPath(path)))
                {
                    // Đọc file
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));
                    StreamReader file = new StreamReader(Server.MapPath(path));

                    members = (List<Member>)reader.Deserialize(file);
                    members = members.OrderBy(Member => Member.ID).ToList();
                    file.Close();
                }


                Member mb = new Member();
                mb.ID = members.Count;
                mb.Email = Request.Form["txtEmail"];
                mb.Ten = Request.Form["txtFullName"];
                mb.Pass1 = Request.Form["txtPass"];
                mb.Doituong = Request.Form["txtDoituong"];

                bool checktrung = false; 
                foreach (Member mem in members)
                {
                    if (mem.Email == mb.Email )
                    {
                        checktrung = true;
                        break;
                    }
                }

                if (!checktrung)
                {
                    foreach (Member mem in members)
                    {
                        if (mem.ID == mb.ID)
                        {
                            mb.ID++;
                        }
                    }
                    members.Add(mb);
                    //Ghi file
                    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<Member>));

                    System.IO.FileStream _file = System.IO.File.Create(Server.MapPath(path));

                    writer.Serialize(_file, members);
                    _file.Close();
                    Application["dsmem"] = members;
                    // Tạo session
                    Session["login"] = true;
                    Session["id"] = mb.ID;
                    Session["email"] = mb.Email;
                    Session["Name"] = mb.Ten;
                    Session["Pass"] = mb.Pass1;
                    Session["Doituong"] = mb.Doituong;

                    if ((bool)Session["login"] == true)
                    {
                        Response.Redirect("login.aspx");
                    }
                }
                else
                {
                    string alert = "";
                    alert += "<script>alert('Tài khoản đã tồn tại!');</script>";
                    Response.Write(alert);
                }
            }
        }
    }
}