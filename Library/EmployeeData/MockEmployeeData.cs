using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id = Guid.NewGuid(), Name = "Employee one"},
            new Employee(){Id = Guid.NewGuid(), Name = "Employee two"},
        };
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            this.employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            this.employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> getEmployees()
        {
            return this.employees;
        }
    }
}
