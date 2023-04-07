using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SetScheduleTest.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetScheduleTest.Models.Mappings
{
    public class USER_INFO : IEntityTypeConfiguration<UserInfo>
    {
        public void Configure(EntityTypeBuilder<UserInfo> entity)
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("USER_INFO");

            entity.Property(e => e.Id).HasColumnName("USER_INFO_ID");

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION")
                .HasMaxLength(500);
            entity.Property(e => e.Hobby)
                .HasColumnName("HOBBY")
                .HasMaxLength(200);
            entity.Property(e => e.Distance).HasColumnName("DISTANCE");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnName("CREATED_ON")
                .HasColumnType("datetime");

            entity.Property(e => e.LastModifiedBy).HasColumnName("LAST_MODIFIED_BY");

            entity.Property(e => e.LastModifiedOn)
                .HasColumnName("LAST_MODIFIED_ON")
                .HasColumnType("datetime");
        }
    }
}
