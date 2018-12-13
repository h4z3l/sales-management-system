using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using SalesManagementSystem.EntityFramework;

namespace SalesManagementSystem
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(SalesManagementSystemCoreModule))]
    public class SalesManagementSystemDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SalesManagementSystemDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
