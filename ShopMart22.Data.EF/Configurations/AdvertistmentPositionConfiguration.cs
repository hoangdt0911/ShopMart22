using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopMart22.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
            // etc.
        }
    }
}
