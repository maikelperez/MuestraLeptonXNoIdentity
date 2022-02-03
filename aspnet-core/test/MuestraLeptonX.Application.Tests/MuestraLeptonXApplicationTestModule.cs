using Volo.Abp.Modularity;

namespace MuestraLeptonX;

[DependsOn(
    typeof(MuestraLeptonXApplicationModule),
    typeof(MuestraLeptonXDomainTestModule)
    )]
public class MuestraLeptonXApplicationTestModule : AbpModule
{

}
