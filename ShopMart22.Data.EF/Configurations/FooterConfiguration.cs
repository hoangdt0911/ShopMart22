using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMart22.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Configurations
{
    public class FooterConfiguration : DbEntityConfiguration<Footer>
    {
        public override void Configure(EntityTypeBuilder<Footer> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255)
                .IsUnicode(false).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
