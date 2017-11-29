using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using ZD.InfoManager.Core;

namespace ZD.InfoManager.EntityFramework
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule),typeof(InfoManagerCoreModule))]
    public class InfoManagerDataModule:AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
