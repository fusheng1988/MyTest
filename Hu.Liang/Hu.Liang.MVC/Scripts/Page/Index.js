var login={
    OnBegin: function (msg) {
   
    },
    OnSuccess: function (msg) {
        alert(msg.success);
        if (msg.success==true) {
            window.location.href = msg.url;
        } else {
            $("#form0").showError(msg);
        }
    },
    OnFailure: function (msg) {

    },

}