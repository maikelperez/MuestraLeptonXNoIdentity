using MuestraLeptonX.Localization;
using Volo.Abp.Application.Services;

namespace MuestraLeptonX;

/* Inherit your application services from this class.
 */
public abstract class MuestraLeptonXAppService : ApplicationService
{
    protected MuestraLeptonXAppService()
    {
        LocalizationResource = typeof(MuestraLeptonXResource);
    }
}
