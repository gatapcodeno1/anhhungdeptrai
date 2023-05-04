<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quanlymonhoc.aspx.cs" Inherits="BTL_WEB.Quanlymonhoc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Thêm môn học</title>
    <link href="CSS/xulymonhoc.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <!-- Header -->
    <header class="header" id="header">
        <div class="container header__menu">
            <div class="menu__logo">
                <a href="#"><img src="Img/logo.png" alt="logo" class="nav__logo-img img"/></a>
            </div>

            <div class="menu__loggin">
                    <span class="log-user" ID="txtTen" runat="server"></span>
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
        <form runat="server" id="form_add" method="post" onsubmit="return check()">
            <h2>Quản lý bài giảng</h2>
            <label>Tiêu đề</label>
            <input type="text" name="txtName" id="txtName" />
            <br />
            <input type="radio" value="môn chính" name="theloai"/>Môn chính
            <input type="radio" value="môn phụ"  name="theloai" style="margin-left: 60px;"/>Môn phụ
            <br />
            <label>Nội dung</label>
            <textarea name="txtNoidung" id="txtNoidung"></textarea>
            <br />
            <label>Link video</label>
            <input type="url" name="txtLinkvid" id="txtLinkvid"/>
            <br />
            <br />
            <label>Link tham khảo</label>
            <br />
            <input type="url" name="txtLinktk" id="txtLinktk" style="width: 100%;"/>
            <br />
            <!--
            <input type="date" name="txtDate" id="txtDate"/>
            <label>Ngày đăng</label>--> 
            <br />
            <br />
            <p runat="server" id="tb" style="color: red;"></p>
            <input name="id_monhoc" value="" type="text" style="display:none;" id="id_monhoc" runat="server"/>
            <asp:Button  ID="delete_btn" OnClick="delete_btn_Click" runat="server" Text="Xóa" CssClass="f_btn"/>
            <asp:Button  ID="edit_btn" OnClick="edit_btn_Click" runat="server" Text="Sửa" CssClass="f_btn"/>
            <asp:Button  ID="submit_btn" OnClick="submit_Click" runat="server" Text="Thêm" CssClass="f_btn"/>
        </form>
        <div>
            <h2 style="text-align: center;">Danh sách môn học</h2>
            <table>
            <thead>
                <tr>
                    <th class="auto">STT</th>
                    <th>Tên</th>
                    <th>Thể loại</th>
                </tr>
            </thead>
            <tbody runat="server" id="noidung">

            </tbody>
        </table>
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
    <script src="JS/xulymonhoc.js" type="text/javascript"></script>
</body>
</html>
