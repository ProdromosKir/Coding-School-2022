using PetShopLib.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session15.EF.Context;

namespace Session15.EF.Repositories
{
    internal class EmployeeRepo : IEntityRepo<Employee>
    {
        public async Task Create(Employee entity)
        {
            using var context = new Session15_Context();
            context.Employees.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new Session15_Context();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            await context.SaveChangesAsync();
        }

        public List<Employee> GetAll()
        {
            using var context = new Session15_Context();
            return context.Employees.ToList();

        }

        public Employee? GetById(Guid id)
        {
            using var context = new Session15_Context();
            return context.Employees.Where(employee => employee.ID == id).SingleOrDefault();
        }

        public Task Update(Employee entity, Guid id)
        {
            using var context = new Session15_Context();
            return Task.CompletedTask;
            //TODO: NA YLOPOIHSW THN UPDATE
        }
    }
}
