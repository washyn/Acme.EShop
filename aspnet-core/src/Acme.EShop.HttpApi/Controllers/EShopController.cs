using Acme.EShop.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.EShop.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EShopController : AbpControllerBase
{
    protected EShopController()
    {
        LocalizationResource = typeof(EShopResource);
    }
}
