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
        url: "/User/saveuser",
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
        error:function (error){
            alert("Nope");
        }

    });
    debugger;
}
