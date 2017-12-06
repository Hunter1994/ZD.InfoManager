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
                //�����û�����
                new InitialHostDbBuilder(context).Create();

                //Ĭ���⻧����
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //������Ϊ�⻧���ݿ�������Ӳ�ʹ���⻧����...
            }
            context.SaveChanges();
        }
    }
}
