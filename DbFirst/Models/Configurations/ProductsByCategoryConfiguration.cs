﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using DbFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DbFirst.Models.Configurations
{
    public partial class ProductsByCategoryConfiguration : IEntityTypeConfiguration<ProductsByCategory>
    {
        public void Configure(EntityTypeBuilder<ProductsByCategory> entity)
        {
            entity.ToView("Products by Category");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<ProductsByCategory> entity);
    }
}
