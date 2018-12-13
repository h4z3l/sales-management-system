using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SalesManagementSystem.EntityFramework;

namespace SalesManagementSystem.Migrator
{
    [DependsOn(typeof(SalesManagementSystemDataModule))]
    public class SalesManagementSystemMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SalesManagementSystemDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}