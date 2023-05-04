<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Timkiem.aspx.cs" Inherits="BTL_WEB.Timkiem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tìm kiếm</title>
<link href="CSS/trangchu.css" type="text/css" rel="stylesheet"/>
    <style>
        .find {
            padding-top: 130px;
        }
        .footer-icon img {
            width: 20px;
        }
        #form_timkiem {
            height: 150px;
            text-align: center;
            margin: 0 12rem;
        }
        #txtTimkiem {
            width: 100%;
            border: 1px solid black;
            border-radius: 4px;
            padding: 0.5rem;
        }
        .btn_timkiem {
            padding: 0.5rem;
            border-radius: 4px;
            cursor: pointer;
            margin-top: 1rem;
        }
        .btn_timkiem:hover {
            background: aqua;
        }
    </style>
</head>
    <body>
    <!-- Header -->
    <header class="header" id="header">
        <div class="container header__menu">
            <div class="menu__logo">
                <a href="#"><img src="Img/logo.png" alt="logo" class="nav__logo-img img"/></a>
            </div>

            <div class="menu__loggin">
                    <span class="log-user" id="txtTen" runat="server"></span>
                <div class="menu__log-icon-user"><img src="Img/icon6.png"/>
                    <div class="log-out">
                        <a href="Login.aspx">Đăng xuất</a>
                    </div>
                </div>

                <div class="icon-open">
                    <i class="fas fa-bars"></i>
                </div>

                <div class="icon-close">
                    <i class="fas fa-times"></i>
                </div>
            </div>
        </div>
        <!-- NAV -->
        <nav class="nav__list container">
            <ul class="nav__list-ul">
                <li class="nav__item">
                    <a href="Trangchu.aspx" class="nav__link">Trang chủ</a>
                </li>
                <li class="nav__item">
                    <a href="timkiem.aspx" class="nav__link">
                        Tìm kiếm
                    </a>
                </li>
            </ul>
            <ul runat="server" id="nav">

            </ul>
        </nav>
    </header>

    <!--Main--->
        <main class="find container">
            <form id="form_timkiem" method="post" runat="server" onsubmit="return check1()">
                <input type="text" name="txtTimkiem" id="txtTimkiem" placeholder="Nhập thể loại môn,môn học cần tìm" runat="server"/>
                <asp:Button ID="find" OnClick="find_Click" runat="server" Text="Tìm kiếm" CssClass="btn_timkiem"/>
            </form>

            <div class="container section-category">
                <div class="grid category-grid" runat="server" id="noidung">
                    
                </div>
            </div>

            <p runat="server" id="none" style="text-align: center;"></p>
        </main>
    <!-- Footer -->
    <footer class="footer" id="footer">
        <div class="container container-footer">
             <div class="contact">
                <p class="contact-des">Liên hệ chúng tôi</p>
                <ul class="list-contact">
                    <li>Khoa công nghệ thông tin-Đại học Mở Hà Nội</li>
                    <li>Điện thoại: 0961046020</li>
                    <li>Email: chubedan@gmail.com</li>
                </ul>
            </div>
        </div>
        <p class="coppyright">Coppyright &#169; 2021 - Developed by <span>nhóm 20</span></p>
    </footer>
    <script src="JS/xulymonhoc.js"></script>
</body>
</html>
<!--//List<Danhsachmon> dstk = new List<Danhsachmon>();
            /*string search = txtTimkiem.Value.Trim().ToLower();
            foreach (Danhsachmon mon in arr)
            {
                if (mon.Type.ToLower().Contains(search)||mon.Des.ToLower().Contains(search))
                {
                    dstk.Add(mon);
                }
            }
            Session["TimKiem"] = dstk;
            List<Danhsachmon> ds = (List<Danhsachmon>)Session["TimKiem"];
           noidung.InnerHtml = "";
           foreach (Danhsachmon mon in ds)
           {
               inner = "<div class='category-content'><img src = " + mon.Img + " alt = '' class='category-img'/><p class='category-title'>" + mon.Des + "</p><a href = 'Chitietmonhoc.aspx?id=" + mon.ID + "&type=" + mon.Type + "'class='category-link'><button class='category-btn'>Học ngay</button></a></div>";
               noidung.InnerHtml += inner;
           }*/-->
