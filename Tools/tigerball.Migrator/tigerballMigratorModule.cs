using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using tigerball.EntityFramework;

namespace tigerball.Migrator
{
    [DependsOn(typeof(tigerballDataModule))]
    public class tigerballMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<tigerballDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}