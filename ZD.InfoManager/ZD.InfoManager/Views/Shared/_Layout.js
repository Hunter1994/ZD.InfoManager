(function () {
    $(function () {

        var _userService = abp.services.app.user;

        $("#UpdateUserBtn").click(function (e) {
            e.preventDefault();
            $.ajax({
                url: abp.appPath +"User/UpdateCurrentUser",
                type: "get",
                contentType: "application/html",
                success: function (content) {
                    $("#UpdateCurrentUser").html(content);
                }
            });
        });

        $("#ComfirmUpdateCurrentUser").live("click",function (e) {
            e.preventDefault();
            var _$form = $("#UpdateCurrentUserForm");
            _$form.validate({
                messages: {
                    Surname: {required:"姓氏不能为空"},
                    Name: { required: "名称不能为空" },
                    EmailAddress: { required: "邮箱不能为空" }
                }
            })

            var _$modal = $("#UpdateCurrentUser");
            if (!_$form.valid()) return;
            var data = _$form.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            _userService.updateCurrent(data).done(function () {
                _$modal.modal('hide');
                location.reload(true);

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });

        });


        $("#UpdatePasswordBtn").click(function (e) {
            e.preventDefault();
            $.ajax({
                url: abp.appPath + "User/UpdatePassword",
                contentType: "application/html",
                type: "get",
                success: function (res) {
                    $("#UpdatePassword").html(res);
                }
            })

        });

        $("#ComfirmUpdatePassword").live("click", function (e) {
            e.preventDefault();
           
            var _$UpdatePasswordForm = $("#UpdatePasswordForm");
            _$UpdatePasswordForm.validate({
                rules: {
                    Password: {
                        required: true
                    },
                    NewPassword: {
                        required: true,
                        minlength: 6
                    },
                    RePassword: {
                        required: true,
                        minlength: 6,
                        equalTo: "#NewPassword"
                    },
                },
                messages: {
                    Password: { required: "请输入原密码", minlength: "至少输入六个字符" },
                    NewPassword: { required: "请输入新密码", minlength: "至少输入六个字符" },
                    RePassword: { required: "重新输入新密码", equalTo: "两次输入密码不一致", minlength:"至少输入六个字符" }
                }
            })
            var _$modal = $("#UpdatePassword");
            if (!_$UpdatePasswordForm.valid()) return;
            var data = _$UpdatePasswordForm.serializeFormToObject();
            abp.ui.setBusy(_$modal);
            _userService.updatePassword(data).done(function () {
                toastr.success("修改成功")
                _$modal.modal('hide');
                location.reload(true);

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });

        });


    })
})();