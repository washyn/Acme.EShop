using System;
using Volo.Abp.Application.Dtos;

namespace Acme.EShop.Products;

public class ProductDto : EntityDto<Guid>
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
}