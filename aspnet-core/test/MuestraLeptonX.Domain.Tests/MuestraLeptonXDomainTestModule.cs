using MuestraLeptonX.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MuestraLeptonX;

[DependsOn(
    typeof(MuestraLeptonXEntityFrameworkCoreTestModule)
    )]
public class MuestraLeptonXDomainTestModule : AbpModule
{

}
