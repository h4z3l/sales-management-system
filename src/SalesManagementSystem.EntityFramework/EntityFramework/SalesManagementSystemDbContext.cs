using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using SalesManagementSystem.Authorization.Roles;
using SalesManagementSystem.Authorization.Users;
using SalesManagementSystem.MultiTenancy;

namespace SalesManagementSystem.EntityFramework
{
    public class SalesManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SalesManagementSystemDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SalesManagementSystemDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SalesManagementSystemDbContext since ABP automatically handles it.
         */
        public SalesManagementSystemDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SalesManagementSystemDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SalesManagementSystemDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
