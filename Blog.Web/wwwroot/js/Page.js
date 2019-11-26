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
    }
}