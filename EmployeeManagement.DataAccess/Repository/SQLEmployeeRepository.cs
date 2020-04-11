﻿using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.DataAccess.Model;
using EmployeeManagement.DataAccess.Repository.Interface;

namespace EmployeeManagement.DataAccess.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public SqlEmployeeRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Employee Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _context.Employees.Find(Id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            return _context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = _context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return employeeChanges;
        }
    }
}
