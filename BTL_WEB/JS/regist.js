function check1() {
    var loi1 = "", soloi1 = 0;
    var dem = 0;

    //check lỗi email
    var email = document.getElementById("txtEmail");
    var regMail = /^([a-zA-Z0-9](\.|_)?)+([a-zA-Z0-9])+\@([a-zA-Z0-9])+(\.?[a-zA-Z0-9]){2}\.[a-z]{2,3}$/;
    if (!regMail.test(email.value)) {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Bạn phải nhập đúng dạng email (tên đăng nhập)";
        email.style.border = "1px solid black";
        email.style.borderRadius = "55px";
        email.style.height = "55px";
    } else {
        email.style.border = "";
    }


    //check lỗi nhập lại pass
    var txtRe_Pass = document.getElementById("txtRe_Pass");
    if (txtRe_Pass.value != txtPass.value) {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Bạn phải nhập lại password trùng với password ở trên";
        txtRe_Pass.style.border = "1px solid black";
        txtRe_Pass.style.borderRadius = "55px";
        txtRe_Pass.style.height = "55px";
    } else {
        txtRe_Pass.style.border = "";
    }

    //check lỗi họ tên
    var ten = document.getElementById("txtFullName");
    if (txtFullName.value == "") {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Bạn phải nhập họ và tên";
        ten.style.border = "1px solid black";
        ten.style.borderRadius = "55px";
        ten.style.height = "55px";
    } else {
        ten.style.border = "";
    }

    //check lỗi k chọn đối tượng
    var txtdoituong1 = document.getElementsByName("txtDoituong")[0];
    var txtdoituong2 = document.getElementsByName("txtDoituong")[1];
    if (txtdoituong1.checked == false && txtdoituong2.checked == false) {
        soloi1++;
        loi1 += "\n" + String(soloi1) + ".Bạn phải chọn đối tượng";
    }
    if (soloi1 != 0) {
        alert(loi1);
        return false;
    }
    return true;
}