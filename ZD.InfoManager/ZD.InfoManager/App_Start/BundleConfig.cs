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
               Include("~/lib/media/js/app.js")
               );



        }
    }
}
