var Page = {
    Contact: {
        Send: function () {
          

            var name = $("#Name").val();
            var surname = $("#Surname").val();
            var message = $("#Message").val();

            if (name && name.length < 2) {
                alert("İsim alanı 2 karakterden az olamaz!");
                return;
            }
            else if (surname && surname.length < 2) {
                alert("Soyisim alanı 2 karakterden az olamaz!");
                return;
            }
            else if (message && message.length < 2) {
                alert("Mesajı alanı en az 2 karakterden oluşmalı!");
                return;
            }

            $("#Contact-Index-Form").hide();
            $("#Contact-Index-Sending").show();

            var data = {
                Name: name,
                Surname: surname,
                Message: message
            };

            $.ajax({
                type: "POST",
                url: "/Contact/Send",
                data: JSON.stringify(data),
                success: Page.Contact.Send_Callback,
                error: Page.Contact.Send_Callback_Error,
                dataType: "json",
                contentType:"application/json"

            });
        },
        Send_Callback: function (result) {
            $("#Contact-Index-Sending").hide();
            $("#Contact-Index-Sent").show();
            console.log(result);
        },
        Send_Callback_Error: function (request, status, error) {
            $("#Contact-Indext-Sending").hide();
            $("#Contact-Indext-Sent").hide();
            $("#Contact-Indext-Form").show();
            alert("Validation Error !");
        }
    },
    User: {
        Login: {
            LoginButton: function () {
                var email = $("#Email").val();
                var password = $("#Password").val();

                var data = {
                    Email: email,
                    Password: password
                };
                $.ajax({
                    type: "POST",
                    url: "/User/LoginAction",
                    data: JSON.stringify(data),
                    success: Page.User.Login.LoginButton_Callback,
                    error: Page.User.Login.LoginButton_Callback_Error,
                    dataType: "json",
                    contentType: "application/json"
                });
            },
            LoginButton_Callback: function (result) {
                console.log(result);
                window.location.href = "/";
            },
            LoginButton_Callback_Error: function (request, status, error) {
                console.log(error);
                console.log(status);
                console.log(request);
            
            }

        }
    },
    Blog: {
        New: {
            Save: function () {
                var title = $("#Title").val();
                var content = $("#Content").val();
                var data = {
                    Title: title,
                    Content: content

                };
                $.ajax({
                    type: "POST",
                    url: "/Blog/Add",
                    data: JSON.stringify(data),
                    success: Page.Blog.New.Save_Callback,
                    error: Page.Blog.New.Save_Callback_Error,
                    dataType: "json",
                    contentType: "application/json"
                });

            },
            Save_Callback: function (result) {
                console.log(result);
            },
            Save_CallbackError: function (request, status, error) {
                console.log(request);
                console.log(status);
                console.log(error);
            }
        }
    }
}