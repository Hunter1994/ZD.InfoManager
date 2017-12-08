(function () {
    $(function () {

        var $loginForm = $("#Registion");
        $loginForm.validate({
            messages: {
                UserName: {
                    required: "请输入用户名",
                    maxlength: jQuery.format("用户名不能超过{0}个字符")
                },
                Password:
                {
                    required: "请输入密码"
                },
                RPassword: { required: "请输入重复密码" },
                EmailAddress: {
                    required: "请输入邮箱",
                    email:"email格式不正确"
                }
            }
        })


        $("#register-back-btn").click(function () {
            location.href="login"
        });

        $("#register-submit-btn").click(function (e) {
            e.preventDefault();
            if (!$loginForm.valid()) return;

        });


    });
})();