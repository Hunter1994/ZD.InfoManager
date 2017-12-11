using Abp.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Abp.AutoMapper;
using ZD.InfoManager.EntityFramework;
using ZD.InfoManager.Application;
using ZD.InfoManager.WebApi;
using Abp.Web.SignalR;
using Abp.Web.Mvc;
using Castle.MicroKernel.Registration;
using Microsoft.Owin.Security;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using Abp.Zero.Configuration;

namespace ZD.InfoManager.App_Start
{

    [DependsOn(typeof(InfoManagerDataModule),
        typeof(InfoManagerApplicationModule),
        typeof(InfoManagerWebApiModule),
        typeof(AbpWebSignalRModule),
        typeof(AbpWebMvcModule))]
    public class InfoManagerWebModule:AbpModule
    {
        public override void PreInitialize()
        {
            //启用数据库本地化
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //配置导航/菜单
            Configuration.Navigation.Providers.Add<InfoManagerNavigationProvider>();

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //将IAuthenticationManager注册为HttpContext.Current.GetOwinContext().Authentication
            //AccountController控制器需要IAuthenticationManager
            IocManager.IocContainer.Register(
                Component.
                For<IAuthenticationManager>().
                UsingFactoryMethod(() => HttpContext.Current.GetOwinContext().Authentication).
                LifestyleTransient()
            );

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

    }
}