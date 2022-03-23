using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session15.EF.Configuration
{
    internal class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            builder.ToTable("Pet Food");

            builder.HasKey(petfood => petfood.ID);

            builder.Property(petfood => petfood.Cost);
            builder.Property(petfood => petfood.Price);

            builder.Property(petfood => petfood.AnimalType).HasMaxLength(110);
           
        }
    }
}