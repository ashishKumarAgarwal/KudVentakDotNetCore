using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.DataAccess.Model;

namespace EmployeeManagement.DataAccess.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
    }
}
