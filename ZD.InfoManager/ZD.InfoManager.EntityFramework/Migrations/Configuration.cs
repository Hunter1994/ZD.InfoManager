namespace ZD.InfoManager.EntityFramework.Migrations
{
    using Abp.Zero.EntityFramework;
    using global::EntityFramework.DynamicFilters;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Abp.MultiTenancy;
    using ZD.InfoManager.EntityFramework.Migrations.SeedData;

    internal sealed class Configuration : DbMigrationsConfiguration<ZD.InfoManager.EntityFramework.EntityFramework.InfoManagerDbContext>, IMultiTenantSeed
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public AbpTenantBase Tenant { get; set; }

        protected override void Seed(ZD.InfoManager.EntityFramework.EntityFramework.InfoManagerDbContext context)
        {
            context.DisableAllFilters();
            if (Tenant == null)
            {
                //主机用户种子
                new InitialHostDbBuilder(context).Create();

                //默认租户种子
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //您可以为租户数据库添加种子并使用租户属性...
            }
            context.SaveChanges();
        }
    }
}
