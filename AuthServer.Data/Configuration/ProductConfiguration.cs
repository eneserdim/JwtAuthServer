using AuthServer.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200); //Girilmesi zorunlu ve en fazla 200 karakter uzunluğunda.
            builder.Property(x => x.Stock).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ID).IsRequired();
        }
    }
}
