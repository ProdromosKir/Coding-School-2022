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
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(pet => pet.ID);

            builder.Property(pet => pet.Breed).HasMaxLength(100);

            builder.Property(pet => pet.PetStatus).HasMaxLength(100);
            builder.Property(pet => pet.AnimalType).HasMaxLength(100);


            builder.Property(pet => pet.Cost);
            builder.Property(pet => pet.Price);
        }
    }
}
