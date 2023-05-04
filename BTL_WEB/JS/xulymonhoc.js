function clickBaigiang() {
    var mh = document.querySelectorAll('.monhoc');
    mh.forEach(function (item) {
        item.addEventListener('click', function (e) {
            document.getElementById('txtName').value = this.getElementsByTagName('td')[1].textContent;
            document.getElementById('id_monhoc').value = this.dataset.value;
            document.getElementsByName('theloai').forEach(function (a) {
                if (item.getElementsByTagName('td')[2].textContent == "môn chính" && a.value == "môn chính") {
                    a.checked = "checked";
                }
                else if (item.getElementsByTagName('td')[2].textContent == "môn phụ" && a.value == "môn phụ") {
                    a.checked = "checked";
                }
            });
            document.getElementById('txtNoidung').value = this.getElementsByTagName('td')[3].textContent;
            document.getElementById('txtLinktk').value = this.getElementsByTagName('td')[4].textContent;
            document.getElementById('txtLinkvid').value = this.getElementsByTagName('td')[5].textContent;
        })
    })
}


function check() {
    var nd = document.getElementById('txtName').value;
    var checked_gender = document.querySelector('input[name = "theloai"]:checked');
    var des = document.getElementById('txtNoidung').value;
    var vid = document.getElementById('txtLinkvid').value;
    var tk = document.getElementById('txtLinktk').value;
    var loi = 0, ndloi = "";
    if (nd == '') {
        loi++;
        ndloi += "\n" + String(loi) + ".Tên không được để trống";
        document.getElementById('txtName').style.border = "1px solid red";
    }
    else {
        document.getElementById('txtName').style.border = "1px solid black";
    }
    if (checked_gender != null) { }
    else {
        loi++;
        ndloi += "\n" + String(loi) + ".Vui lòng chọn thể loại";
    }
    if (des == '') {
        loi++;
        ndloi += "\n" + String(loi) + ".Nội dung không được để trống";
        document.getElementById('txtNoidung').style.border = "1px solid red";
    } else {
        document.getElementById('txtNoidung').style.border = "1px solid black";
    }
    if (vid == '') {
        loi++;
        ndloi += "\n" + String(loi) + ".Link video không được để trống";
        document.getElementById('txtLinkvid').style.border = "1px solid red";
    } else {
        document.getElementById('txtLinkvid').style.border = "1px solid black";
    }
    if (tk == '') {
        loi++;
        ndloi += "\n" + String(loi) + ".Link tham khảo không được để trống";
        document.getElementById('txtLinktk').style.border = "1px solid red";
    } else {
        document.getElementById('txtLinktk').style.border = "1px solid black";
    }
    if (isNaN(nd) == false) {
        loi++;
        ndloi += "\n" + String(loi) + ".Sai định dạng của tên môn học";
        document.getElementById('txtNoidung').style.border = "1px solid red";
    }
    if (loi != 0) {
        alert(ndloi);
        return false;
    }
    if (confirm("Bạn có chắc muốn xử lý không?") == true) {
        return true;
    }
    else {
        return false;
    }
}



function check1() {
    var nd = document.getElementById("txtTimkiem").value;
    if (nd == '') {
        alert("Mời bạn nhập thông tin cần tìm!");
        return false;
    }
}


function moveTaget(x) {
    x.style.background = "aqua";
}

function outTaget(x) {
    x.style.background = "none";
}

clickBaigiang();