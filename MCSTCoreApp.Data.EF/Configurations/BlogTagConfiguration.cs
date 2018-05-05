using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Data.EF.Extensions;
using MCSTCoreApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MCSTCoreApp.Data.EF.Configurations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
                .HasColumnType("varchar(50)");
            // etc.
        }
    }
}
