﻿
(function () {
    $(function () {
        //0.初始化fileinput
        var oFileInput = new FileInput();
        oFileInput.Init("txt_file", "/FileUp/ChangeAvatar");
    });
})()


//初始化fileinput
var FileInput = function () {
    var oFile = new Object();

    //初始化fileinput控件（第一次初始化）
    oFile.Init = function (ctrlName, uploadUrl) {
        var control = $('#' + ctrlName);

        //初始化上传控件的样式
        control.fileinput({
            language: 'zh', //设置语言
            uploadUrl: uploadUrl, //上传的地址
            allowedFileExtensions: ['jpg', 'gif', 'png'],//接收的文件后缀
            showUpload: true, //是否显示上传按钮
            showCaption: false,//是否显示标题
            showAjaxErrorDetails:false,
            browseClass: "btn btn-primary", //按钮样式     
            //dropZoneEnabled: false,//是否显示拖拽区域
            //minImageWidth: 50, //图片的最小宽度
            //minImageHeight: 50,//图片的最小高度
            //maxImageWidth: 1000,//图片的最大宽度
            //maxImageHeight: 1000,//图片的最大高度
            //maxFileSize: 0,//单位为kb，如果为0表示不限制文件大小
            //minFileCount: 0,
            maxFileCount: 1, //表示允许同时上传的最大文件个数
            enctype: 'multipart/form-data',
            validateInitialCount: true,
            previewFileIcon: "<i class='icon-trash'></i>",
            removeIcon: "<i class='icon-trash'></i>",
            uploadIcon: "<i class='icon-trash'></i>",
            cancelIcon: "<i class='icon-trash'></i>",
            fileActionSettings: {
                showRemove: false,
                showUpload: false,
                showZoom: false,
                showDrag: false,
                removeIcon: '<i class="glyphicon glyphicon-trash text-danger"></i>',
                removeClass: 'btn btn-xs btn-default',
                removeTitle: 'Remove file',
                uploadIcon: '<i class="glyphicon glyphicon-upload text-info"></i>',
                uploadClass: 'btn btn-xs btn-default',
                uploadTitle: 'Upload file',
                zoomIcon: '<i class="glyphicon glyphicon-zoom-in"></i>',
                zoomClass: 'btn btn-xs btn-default',
                zoomTitle: 'View Details',
                dragIcon: '<i class="glyphicon glyphicon-menu-hamburger"></i>',
                dragClass: 'text-info',
                dragTitle: 'Move / Rearrange',
                dragSettings: {},
                indicatorNew: '<i class="glyphicon glyphicon-hand-down text-warning"></i>',
                indicatorSuccess: '<i class="glyphicon glyphicon-ok-sign text-success"></i>',
                indicatorError: '<i class="glyphicon glyphicon-exclamation-sign text-danger"></i>',
                indicatorLoading: '<i class="glyphicon glyphicon-hand-up text-muted"></i>',
                indicatorNewTitle: 'Not uploaded yet',
                indicatorSuccessTitle: 'Uploaded',
                indicatorErrorTitle: 'Upload Error',
                indicatorLoadingTitle: 'Uploading ...'
            },
            msgFilesTooMany: "选择上传的文件数量({n}) 超过允许的最大数值{m}！",
        });

        //导入文件上传完成之后的事件
        $("#txt_file").on("fileuploaded", function (event, data, previewId, index) {
            //$("#myModal").modal("hide");
            //var data = data.response.lstOrderImport;
            //if (data == undefined) {
            //    toastr.error('文件格式类型不正确');
            //    return;
            //}
            toastr.success("上传成功！");
            //1.初始化表格
            //var oFileInput = new FileInput();
            //oFileInput.Init("txt_file", "/FileUp/ChangeAvatar");
            //$("#div_startimport").show();
        });
    }
    return oFile;
};