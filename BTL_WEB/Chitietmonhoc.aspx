<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chitietmonhoc.aspx.cs" Inherits="BTL_WEB.Chitietmonhoc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chi tiết môn học</title>
    <link href="CSS/chitietmonhoc.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <div class="circle"></div>
    <!-- Header -->
    <header class="header" id="header">
        <div class="container header__menu">
            <div class="menu__logo">
                <a href="#"><img src="Img/logo.png" alt="logo" class="nav__logo-img img"/></a>
            </div>

            <div class="menu__loggin">
                <form runat="server">
                    <span class="log-user" ID="txtTen" runat="server"></span>
                </form>
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

    <!---Main---->
    <main class="main container">
        <div class="main-content">
            <asp:Image runat="server" ID="img" CssClass="img_sub"/>
            <asp:Label runat="server" ID="name" CssClass="img_name"></asp:Label>
            <label>Khái niệm cơ bản</label>
            <asp:Label runat="server" ID="detail" CssClass="main-detail"></asp:Label>
            <label>Video tham khảo</label>
            <iframe runat="server" id="video">
                
            </iframe>
            <label>Tài liệu tham khảo</label>
            <asp:HyperLink runat="server" ID="link" CssClass="main-link">Click vào đây để tìm hiểu thêm!</asp:HyperLink>
        </div>
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
</body>
</html>
