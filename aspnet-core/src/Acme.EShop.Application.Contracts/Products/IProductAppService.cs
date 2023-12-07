using System;
using Volo.Abp.Application.Services;

namespace Acme.EShop.Products;

public interface IProductAppService: ICrudAppService<ProductDto, Guid>
{
    
}