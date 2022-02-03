using MuestraLeptonX.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MuestraLeptonX.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MuestraLeptonXController : AbpControllerBase
{
    protected MuestraLeptonXController()
    {
        LocalizationResource = typeof(MuestraLeptonXResource);
    }
}
