using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using ZD.InfoManager.Core.Authorization;
using ZD.InfoManager.Core.Authorization.Roles;
using ZD.InfoManager.Core.Authorization.Users;
using ZD.InfoManager.Core.Configuration;
using ZD.InfoManager.Core.MultiTenancy;
using Abp.Runtime.Security;

namespace ZD.InfoManager.Core
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class InfoManagerCoreModule:AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //声明实体类型
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //设置多租户
            Configuration.MultiTenancy.IsEnabled = InfoManagerConsts.MultiTenancyEnabled;

            //添加本地化资源
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    InfoManagerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "ZD.InfoManager.Core.Localization.Source"
                        )
                    )
                );

            //配置静态角色
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            //权限配置
            Configuration.Authorization.Providers.Add<InfoManagerAuthorizationProvider>();

            //设置配置
            Configuration.Settings.Providers.Add<AppSettingProvider>();

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
