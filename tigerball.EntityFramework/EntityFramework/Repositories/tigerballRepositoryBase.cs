using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace tigerball.EntityFramework.Repositories
{
    public abstract class tigerballRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<tigerballDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected tigerballRepositoryBase(IDbContextProvider<tigerballDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class tigerballRepositoryBase<TEntity> : tigerballRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected tigerballRepositoryBase(IDbContextProvider<tigerballDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
