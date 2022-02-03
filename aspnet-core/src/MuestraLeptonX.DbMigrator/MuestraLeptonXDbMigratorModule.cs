using MuestraLeptonX.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MuestraLeptonX.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MuestraLeptonXEntityFrameworkCoreModule),
    typeof(MuestraLeptonXApplicationContractsModule)
)]
public class MuestraLeptonXDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });
    }
}
