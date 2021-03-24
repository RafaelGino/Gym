using Domain.Abstractions.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data.Extensions
{
    public static class EntityTypeBuilderExtension
    {
        public static void ConfigureBasicProperties<T>(this EntityTypeBuilder<T> builder, string tableName) where T : Entity
        {
            builder.ToTable(tableName);
            builder.HasKey(x => x.Id).HasName($"PK_{tableName}_ID");
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
        }
    }
}
