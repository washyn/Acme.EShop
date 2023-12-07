using Acme.EShop.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.EShop.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EShopEntityFrameworkCoreModule),
    typeof(EShopApplicationContractsModule)
    )]
public class EShopDbMigratorModule : AbpModule
{
}
