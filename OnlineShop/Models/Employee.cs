using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Employee
    {
        private string employeeName;
        private string employeePassword;
        private Guid employeeuniqueId = new Guid();
        //public string EmployeeName { get; set; }
        //public string EmployeePassword { get; set; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePassword { get => employeePassword; set => employeePassword = value; }

        public Guid EmployeeUniqueId { get => employeeuniqueId; }
    }
}