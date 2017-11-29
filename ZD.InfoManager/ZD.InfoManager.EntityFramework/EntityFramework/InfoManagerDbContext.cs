using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Zero.EntityFramework;
using ZD.InfoManager.Core.Authorization.Roles;
using ZD.InfoManager.Core.Authorization.Users;
using ZD.InfoManager.Core.MultiTenancy;

namespace ZD.InfoManager.EntityFramework.EntityFramework
{
    public class InfoManagerDbContext:AbpZeroDbContext<Tenant,Role,User>
    {
        //TODO 在此处定义IDbSet实体


        public InfoManagerDbContext() : base("Default")
        {
        }

        public InfoManagerDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public InfoManagerDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public InfoManagerDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
