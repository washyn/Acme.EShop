﻿using System;
using Volo.Abp.Domain.Entities;

namespace Acme.EShop.Products;

public class Product : Entity<Guid>
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
}