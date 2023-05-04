<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BTL_WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="CSS/login.css" rel="stylesheet" type="text/css"/>
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
                <form  class="sign-in-form" runat="server" id="form_login" method="post" onsubmit="return check()">
                    <h2 class="title">Đăng nhập</h2>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="email" placeholder="Email" id="txtName_log" name="txtName_log" value="" />
                    </div>
                    <div class="input-field">
                        <img src="Img/icon.png"/>
                        <input type="password" placeholder="Mật khẩu" id="txtPass_log" name="txtPass_log" value="" />
                    </div>
                    <button class="btn solid" type="submit" name="btnLogin" value="true">Đăng nhập</button>
                </form>
                <div class="sign-up">
                    <p>Chưa có tài khoản? <a href="Register.aspx">Đăng ký tại đây</a></p>
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
    <script src="JS/login.js" type="text/javascript"></script>
</body>
</html>
