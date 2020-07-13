using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Service
{
    public class EmployeeService : IEmployeeService
    {
        public static List<Guid> UniqueEmployeeIds = new List<Guid>();
        public static List<Employee> EmployeeList = new List<Employee>() { new Employee() { EmployeeName = "Nani", EmployeePassword = "1234" } };

        public Employee Login(string name, string password)
        {
            Employee emp = null;
            foreach (var employee in EmployeeList)
            {
                if (employee.EmployeeName == name && employee.EmployeePassword == password)
                {
                    emp = employee;
                    Guid id;
                    id = employee.EmployeeUniqueId;
                    UniqueEmployeeIds.Add(id);
                    return emp;
                }
            }
            return null;
        }
    }
}