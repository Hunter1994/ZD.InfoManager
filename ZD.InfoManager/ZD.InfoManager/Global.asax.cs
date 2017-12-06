using Abp;
using Abp.Web;
using System;
using Abp.Castle.Logging.Log4Net;
using ZD.InfoManager.App_Start;
using Castle.Facilities.Logging;

namespace ZD.InfoManager
{
    public class MvcApplication : AbpWebApplication<InfoManagerWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            base.Application_Start(sender, e);
        }
    }
}
