<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trangchu.aspx.cs" Inherits="BTL_WEB.Trangchu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang chủ</title>
    <link href="CSS/trangchu.css" type="text/css" rel="stylesheet"/>
    <style>
        .footer-icon img {
            width: 20px;
        }
    </style>
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
                    <a href="#home" class="nav__link">Trang chủ</a>
                </li>
                <li class="nav__item">
                    <a href="#subject" class="nav__link">
                        Môn học chính
                    </a>
                </li>
                <li class="nav__item">
                    <a href="#sub_subject" class="nav__link">
                        Môn học liên quan
                    </a>
                </li>
                <li class="nav__item">
                    <a href="Timkiem.aspx" class="nav__link">
                        Tìm kiếm
                    </a>
                </li>
            </ul>
            <ul runat="server" id="nav">

            </ul>
        </nav>
    </header>

    <!-- Slider -->
    <slider class="slide-show" id="home">
        <div class="slider">
            <div class="sliders">
                <!-- Content slider -->
                <div class="slide">
                    <img class="slide-img" src="Img/pic1.png" alt="slide"/>
                    <div class="slide-content">
                        <p class="slide-description"> <span> <br/> E-Learning</span></p>
                        <button class="slide-btn"><a href="#about" class="slide-link">Khám phá các môn học!</a></button>
                    </div>
                </div>
            </div>
        </div>
    </slider>

    <main>
        <!-- About -->
        <section class="section" id="about">
            <div class="container section-about">
                <h2 class="section-title">Lợi ích của việc học online</h2>
                <hr class="section-hr"/>
                <div class="section-content">
                    <img src="Img/pic6.png" alt="a" class="section-img"/>
                </div>
            </div>
        </section>

        <!-- Subject -->
        <section class="section section-subject" id="subject">
            <div class="container section-category">
                <h2 class="section-title">Các môn học chính</h2>
                <hr class="section-hr"/>
                <div class="grid category-grid" runat="server" id="monhoc">
                    
                </div>
            </div>
        </section>

        <!-- sub-subject -->
        <section class="section" id="sub_subject">
            <div class="container section-category">
                <h2 class="section-title">Các môn học liên quan</h2>
                <hr class="section-hr"/>
                <div class="grid category-sub-grid" runat="server" id="monphu">
                    
                </div>
            </div>
        </section>
    </main>
    <div style="margin: 0 auto;">
        <p style="text-align:center">Số lượng người truy cập</p>
        <p runat="server" id="sl" style="text-align:center"></p>
    </div>
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
    <!-- Scroll up -->
    <a href="#" class="scrollup" id="scroll-up">
        <i class="fas fa-arrow-up scrollup-icon"></i>
    </a>
</body>
</html>
