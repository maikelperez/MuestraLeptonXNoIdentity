using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MuestraLeptonX;

[Dependency(ReplaceServices = true)]
public class MuestraLeptonXBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MuestraLeptonX";
}
