<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BTL_WEB.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký</title>
    <link rel="stylesheet" type="text/css" href="CSS/login.css"/>
    <style>
        .input-field input {
            border-radius: 55px;
        }
    </style>
</head>
<body>
    <main class="container">
        <div class="form-container">
            <div class="signin-signup">
                <form class="sign-in-form" runat="server" id="form_regist"  method="post" onsubmit="return check1()">
                    <h2 class="title">Đăng ký</h2>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="email" placeholder="Email" id="txtEmail" name="txtEmail"/>
                    </div>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="password" placeholder="Mật khẩu" id="txtPass" name="txtPass" />
                    </div>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="password" placeholder="Nhập lại mật khẩu" id="txtRe_Pass" name="txtRe_Pass" />
                    </div>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="text" placeholder="Nhập họ tên" id="txtFullName" name="txtFullName" />
                    </div>
                    <div id="checkbox">
                        <input type="radio" class="checkbox_son" name="txtDoituong" value="Giáo viên" /><span>Giáo viên</span>
                        
                        <input type="radio" class="checkbox_son" name="txtDoituong" value="Sinh viên" />Sinh viên
                    </div>
                    <button class="btn solid" type="submit" value="true" name="btnRegist">Đăng ký</button>
                </form>
                <div class="sign-up">
                    <p>Đã có tài khoản? <a href="Login.aspx">Đăng nhập tại đây</a></p>
                </div>
            </div>
        </div>

        <div class="panels-container">
            <div class="panel left-panel">
                <div class="content">
                    <h3>Xin Chào</h3>
                    <p>Welcome to E-Learning</p>
                    </div>
                </div>
        </div>
    </main>
    <script src="JS/regist.js"></script>
</body>
</html>
<!--var sdt = document.getElementById('txtSdt');
    var arr = sdt.value.split('');
    if (sdt.value == "") {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Bạn phải nhập sđt";
        sdt.style.border = "1px solid black";
        sdt.style.borderRadius = "55px";
        sdt.style.height = "55px";
    }
    if (isNaN(sdt.value) == true) {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Sai định dạng số điện thoại";
    }
    if (arr[0] !== "0") {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Số điện thoại phải bắt đầu bằng 0";
        console.log(arr[0]);
    }
    if (sdt.value.length < 8 || sdt.value.length > 12) {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Số điện thoại phải lớn hơn 8 và bé hơn 12 số!";
    }-->
