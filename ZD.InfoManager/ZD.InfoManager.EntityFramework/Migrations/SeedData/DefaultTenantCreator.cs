using System.Linq;
using ZD.InfoManager.Core.MultiTenancy;
using ZD.InfoManager.EntityFramework.EntityFramework;

namespace ZD.InfoManager.EntityFramework.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly InfoManagerDbContext _context;

        public DefaultTenantCreator(InfoManagerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
