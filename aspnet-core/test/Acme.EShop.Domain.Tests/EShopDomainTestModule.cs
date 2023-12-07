using Acme.EShop.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.EShop;

[DependsOn(
    typeof(EShopEntityFrameworkCoreTestModule)
    )]
public class EShopDomainTestModule : AbpModule
{

}
