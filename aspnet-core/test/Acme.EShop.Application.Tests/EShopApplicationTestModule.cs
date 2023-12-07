using Volo.Abp.Modularity;

namespace Acme.EShop;

[DependsOn(
    typeof(EShopApplicationModule),
    typeof(EShopDomainTestModule)
    )]
public class EShopApplicationTestModule : AbpModule
{

}
