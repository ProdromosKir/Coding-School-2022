using Microsoft.EntityFrameworkCore;
using PetShopLib.Impl;
using PetShopLib.Enums;
using Session15.EF.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session15.EF.Context
{
    internal class Session15_Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetFood> PetFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //Employee
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder 
                .Entity<Employee>()
                .Property(employee => employee.EmployeeType)
                .HasConversion(
                    v => v.ToString(),
                    v => (EmployeeTypeEnum)Enum.Parse(typeof(EmployeeTypeEnum), v));



            
            //Customer
             modelBuilder.ApplyConfiguration(new CustomerConfiguration());




            //Pet
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder
               .Entity<Pet>()
               .Property(pet => pet.AnimalType)
               .HasConversion(
                   v => v.ToString(),
                   v => (AnimalTypeEnum)Enum.Parse(typeof(AnimalTypeEnum), v));

            modelBuilder
               .Entity<Pet>()
               .Property(pet => pet.PetStatus)
               .HasConversion(
                   v => v.ToString(),
                   v => (PetStatusEnum)Enum.Parse(typeof(PetStatusEnum), v));





            //PetFood
            modelBuilder.ApplyConfiguration(new PetFoodConfiguration());
            modelBuilder
               .Entity<PetFood>()
               .Property(petfood => petfood.AnimalType)
               .HasConversion(
                   v => v.ToString(),
                   v => (AnimalTypeEnum)Enum.Parse(typeof(AnimalTypeEnum), v));


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbEmployee;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connString);
        }


    }
}
