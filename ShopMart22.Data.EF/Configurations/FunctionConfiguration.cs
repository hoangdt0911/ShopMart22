using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMart22.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
                .HasMaxLength(128).IsUnicode(false);
            // etc.
        }
    }
}
