function placeOrder() {
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var data = JSON.stringify({
        'name': name,
        'email': email
    });

    debugger;
    //window.alert("new1");
    //document.getElementById("content").innerHTML = '<object type="type/html" data="AddNewUser.html" ></object>';

    $.ajax({
        url: "/Student/SaveStudent",
        dataType: "json",
        data: data,
        contentType: "application/json; charset=utf-8",
        async: false,
        type: "POST",
        success: function (Redata) {
            debugger;
            alert('value returns');
            alert(Redata.val);
        },
        error: function (error) {
            alert("Nope");
        }

    });
    debugger;
}
function showcalander() {
    //window.alert("clicked");
    //document.getElementById("studentbirthdivcal").style.cssText = 'display:block'
    if ($('#studentbirthdivcal').css('display') == 'none') {
        document.getElementById("studentbirthdivcal").style.cssText = 'display:block'
        getDate();
        $("#calendar").datepicker("autoclose", true);
    }
    else {
        document.getElementById("studentbirthdivcal").style.cssText = 'display:none'
    }


}

function getDate() {
    var todaydate = new Date();
    var day = todaydate.getDate();
    var month = todaydate.getMonth() + 1;
    var year = todaydate.getFullYear();
    var datestring = day + "/" + month + "/" + year;
    document.getElementById("studentbirthday").value = datestring;
}

function displaydate()
{
   
}

$(function () {
    $('#datetimepicker1').datetimepicker();
});


$(document).ready(function () {
    var date_input = $('input[name="date"]'); //our date input has the name "date"
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'mm/dd/yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
    };
    date_input.datepicker(options);
})

//profilepic

$(document).on('change', '.btn-file :file', function () {
    var input = $(this),
        label = input.val().replace(/\\/g, '/').replace(/.*\//, '');
    input.trigger('fileselect', [label]);
});

$('.btn-file :file').on('fileselect', function (event, label) {

    var input = $(this).parents('.input-group').find(':text'),
        log = label;

    if (input.length) {
        input.val(log);
    } else {
        if (log) alert(log);
    }

});
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#img-upload').attr('src', e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}

$("#imgInp").change(function () {
    readURL(this);
});