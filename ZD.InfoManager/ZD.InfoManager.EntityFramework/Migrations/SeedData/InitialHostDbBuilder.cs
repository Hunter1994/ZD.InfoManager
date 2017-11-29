using ZD.InfoManager.EntityFramework.EntityFramework;
using EntityFramework.DynamicFilters;

namespace ZD.InfoManager.EntityFramework.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly InfoManagerDbContext _context;

        public InitialHostDbBuilder(InfoManagerDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
