using Abp.MultiTenancy;
using ZD.InfoManager.Core.Authorization.Users;

namespace ZD.InfoManager.Core.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}