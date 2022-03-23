using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopLib.Impl;
using Session15.EF;


namespace Session15.EF.Repositories
{
    public class MockEmployeeRepo : IEntityRepo<Employee>
    {

        //private List<Todo> _todos = new List<Todo>() { new Todo("Todo1") { Id = 1 }, new Todo("Todo2") { Id = 2 } };
        private List<Employee> _employees = new List<Employee>() { new Employee("Pro","Kir",800)};

        public Task Create(Employee entity)
        {
            _employees.Add(entity);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            var foundEmployee = _employees.SingleOrDefault(employee => employee.ID == id);
            if (foundEmployee is null)
                return Task.CompletedTask;
            _employees.Remove(foundEmployee);
            return Task.CompletedTask;
        }

        public List<Employee> GetAll()
        {
           return _employees;
        }

        public Employee? GetById(Guid id)
        {
            return _employees.SingleOrDefault(employee => employee.ID == id);
        }

        public Task Update(Employee entity, Guid id)
        {
            return Task.CompletedTask;
            //TODO: 2 NA YLOPOIHSW KAI EDW THN UPDATE
        }
    }
}
