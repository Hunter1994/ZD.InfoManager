using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ZD.InfoManager.EntityFramework.EntityFramework.Repositories
{
    public abstract class InfoManagerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<InfoManagerDbContext, TEntity, TPrimaryKey>
         where TEntity : class, IEntity<TPrimaryKey>
    {
        protected InfoManagerRepositoryBase(IDbContextProvider<InfoManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class InfoManagerRepositoryBase<TEntity> : InfoManagerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected InfoManagerRepositoryBase(IDbContextProvider<InfoManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
