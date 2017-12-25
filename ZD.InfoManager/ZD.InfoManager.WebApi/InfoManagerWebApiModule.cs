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
using Swashbuckle.Application;

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
            ConfigureSwaggerUi();
        }

        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "ZD.InfoManager");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                })
                  .EnableSwaggerUi(c =>
                  {
                      c.InjectJavaScript(Assembly.GetAssembly(typeof(InfoManagerWebApiModule)), "ZD.InfoManager.WebApi.js.Swagger-Custom.js");
                  });
        }
    }
}
