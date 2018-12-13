using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SalesManagementSystem.EntityFramework.Repositories
{
    public abstract class SalesManagementSystemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SalesManagementSystemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SalesManagementSystemRepositoryBase(IDbContextProvider<SalesManagementSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SalesManagementSystemRepositoryBase<TEntity> : SalesManagementSystemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SalesManagementSystemRepositoryBase(IDbContextProvider<SalesManagementSystemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
