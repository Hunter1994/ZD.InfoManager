using Abp.Modules;
using Abp.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZD.InfoManager.Application;
using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Application.Services;
using System.Web.Http;

namespace ZD.InfoManager.WebApi
{
    [DependsOn(typeof(AbpWebApiModule), typeof(InfoManagerApplicationModule))]
    public class InfoManagerWebApiModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder.ForAll<IApplicationService>(typeof(InfoManagerApplicationModule).Assembly, "app").
                Build();

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        }
    }
}
