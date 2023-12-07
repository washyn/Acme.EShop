using System.Threading.Tasks;

namespace Acme.EShop.Data;

public interface IEShopDbSchemaMigrator
{
    Task MigrateAsync();
}
