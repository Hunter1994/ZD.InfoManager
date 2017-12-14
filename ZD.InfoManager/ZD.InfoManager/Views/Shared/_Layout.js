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



    })
})();