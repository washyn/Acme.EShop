using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.EShop;

[Dependency(ReplaceServices = true)]
public class EShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EShop";
}
