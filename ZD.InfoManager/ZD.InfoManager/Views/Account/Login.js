
(function () {
    $(function () {

        var $loginForm = $("#LoginForm");

        $loginForm.validate({
            messages: {
                UsernameOrEmailAddress: { required: "请输入用户名或邮箱" },
                Password: { required:"请输入密码"}
            }
        })


        $loginForm.submit(function (e) {
            e.preventDefault();

            if (!$loginForm.valid()) return;
            console.log($loginForm.serialize());
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