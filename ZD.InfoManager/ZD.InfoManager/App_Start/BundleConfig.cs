using System.Web;
using System.Web.Optimization;

namespace ZD.InfoManager
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            bundles.Add(new StyleBundle("~/Bundles/media/css").
                Include("~/lib/media/css/bootstrap.min.css").
                Include("~/lib/media/css/bootstrap-responsive.min.css").
                Include("~/lib/media/css/font-awesome.min.css").
                Include("~/lib/media/css/style-metro.css").
                Include("~/lib/media/css/style.css").
                Include("~/lib/media/css/style-responsive.css").
                Include("~/lib/media/css/default.css").
                Include("~/lib/media/css/uniform.default.css")
                );

            bundles.Add(new ScriptBundle("~/Bundles/media/js").
               Include("~/lib/media/js/jquery-1.10.1.min.js").
               Include("~/lib/media/js/jquery-migrate-1.2.1.min.js").
               Include("~/lib/media/js/jquery-ui-1.10.1.custom.min.js").
               Include("~/lib/media/js/bootstrap.min.js").
               Include("~/lib/media/js/jquery.slimscroll.min.js").
               Include("~/lib/media/js/jquery.blockui.min.js").
               Include("~/lib/media/js/jquery.cookie.min.js").
               Include("~/lib/media/js/jquery.uniform.min.js").
               Include("~/lib/media/js/jquery.validate.min.js").
               Include("~/lib/media/js/app.js"))
               ;


            bundles.Add(new StyleBundle("~/Bundles/abp/css").
               Include("~/lib/sweetalert/dist/sweetalert.css").
               Include("~/lib/toastr/toastr.css")
               );
            bundles.Add(new ScriptBundle("~/Bundles/abp/js").
              Include("~/lib/json2/json2.js").
              Include("~/lib/moment/min/moment-with-locales.js").
              Include("~/lib/jquery-validation/dist/jquery.validate.js").
              Include("~/lib/blockUI/jquery.blockUI.js").
              Include("~/lib/spin.js/spin.js").
              Include("~/lib/spin.js/jquery.spin.js").
              Include("~/lib/sweetalert/dist/sweetalert-dev.js").
              Include("~/lib/toastr/toastr.js").
              Include("~/Abp/Framework/scripts/abp.js").
              Include("~/Abp/Framework/scripts/libs/abp.jquery.js").
              Include("~/Abp/Framework/scripts/libs/abp.toastr.js").
              Include("~/Abp/Framework/scripts/libs/abp.blockUI.js").
              Include("~/Abp/Framework/scripts/libs/abp.spin.js").
              Include("~/Abp/Framework/scripts/libs/abp.sweet-alert.js").
              Include("~/js/main.js").
              Include("~/Views/Shared/_Layout.js")
              );

            //bootstrap fileinput
            bundles.Add(new ScriptBundle("~/Bundles/bootstrap-fileinput/js").Include(
                        "~/lib/bootstrap-fileinput-master/js/fileinput.min.js",
                        "~/lib/bootstrap-fileinput-master/js/locales/zh.js"));
            bundles.Add(new StyleBundle("~/Bundles/bootstrap-fileinput/css").Include(
                        "~/lib/bootstrap-fileinput-master/css/fileinput.min.css"));

            //bootstrap-table-develop
            bundles.Add(new ScriptBundle("~/Bundles/bootstrap-table-develop/js").Include(
                       "~/lib/bootstrap-table-develop/dist/bootstrap-table.min.js",
                       "~/lib/bootstrap-table-develop/dist/locale/bootstrap-table-zh-CN.min.js"));
            bundles.Add(new StyleBundle("~/Bundles/bootstrap-table-develop/css").Include(
                        "~/lib/bootstrap-table-develop/dist/bootstrap-table.css"));
        }
    }
}
