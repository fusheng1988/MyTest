var login={
    OnBegin: function (msg) {
   
    },
    OnSuccess: function (msg) {
        alert(msg.success);
        if (msg.success==true) {
            window.location.href = msg.url;
        } else {
            alert(msg.message);
        }
    },
    OnFailure: function (msg) {

    },

}