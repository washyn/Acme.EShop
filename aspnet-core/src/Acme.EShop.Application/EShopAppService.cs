using System;
using System.Collections.Generic;
using System.Text;
using Acme.EShop.Localization;
using Volo.Abp.Application.Services;

namespace Acme.EShop;

/* Inherit your application services from this class.
 */
public abstract class EShopAppService : ApplicationService
{
    protected EShopAppService()
    {
        LocalizationResource = typeof(EShopResource);
    }
}
