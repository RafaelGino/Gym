using Gym.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Infra.Data.Extensions;

namespace Infra.Data
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ConfigureBasicProperties("Customer");

            builder.Property(x => x.Active).HasColumnName("Active");
            builder.Property(x => x.Address).HasColumnName("Address");
            builder.Property(x => x.Age).HasColumnName("Age");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.FirstName).HasColumnName("FirstName");
            builder.Property(x => x.Height).HasColumnName("Height");
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.MiddleName).HasColumnName("MiddleName");
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.PrimaryPhone).HasColumnName("PrimaryPhone");
            builder.Property(x => x.SecondaryPhone).HasColumnName("SecondaryPhone");
            builder.Property(x => x.Weight).HasColumnName("Weight");
            builder.Property(x => x.ZipCode).HasColumnName("ZipCode");

            //builder.HasMany(x => x.Classes)
        }
    }
}
