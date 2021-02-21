using Library.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext { get; set; }
        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            this._employeeContext = employeeContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = _employeeContext.Employees.Find(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                _employeeContext.Employees.Update(existingEmployee);
                _employeeContext.SaveChanges();
            }
            return employee;
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _employeeContext.Employees.Find(id);
            //return _employeeContext.Employees.SingleOrDefault(x => x.Id == id);
            return employee;
        }

        public List<Employee> getEmployees()
        {
            return _employeeContext.Employees.ToList();
        }
    }
}
