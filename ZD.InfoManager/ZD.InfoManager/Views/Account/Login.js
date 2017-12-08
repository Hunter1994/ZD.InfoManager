
(function () {
    $(function () {

        var $loginForm = $("#LoginForm");

        $loginForm.submit(function (e) {
            e.preventDefault();

            if (!$loginForm.valid()) return;

            abp.ui.setBusy($("#LoginArea"),
                abp.ajax({
                    contentType: "application/x-www-form-urlencoded",
                    url: $loginForm.attr("action"),
                    data: $loginForm.serialize(),
                    success: function (res) {
                        console.log(res)
                    }
                })
            );

        })




    });

})();