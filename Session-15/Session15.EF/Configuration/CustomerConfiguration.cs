using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLib.Impl;

namespace Session15.EF.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(customer => customer.ID);

            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.SurName).HasMaxLength(100);

            builder.Property(customer => customer.TIN);
            builder.Property(customer => customer.Phone);
        }
    }
}
