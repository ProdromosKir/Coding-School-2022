using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Session15.EF.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(employee => employee.ID);

            builder.Property(employee => employee.Name).HasMaxLength(100);
            builder.Property(employee => employee.SurName).HasMaxLength(100);

            
            builder.Property(employee => employee.SalaryPerMonth);
            builder.Property(employee => employee.EmployeeType).HasMaxLength(70);
        }
    }
}
