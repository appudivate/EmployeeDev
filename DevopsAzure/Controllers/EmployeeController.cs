using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevopsAzure.Models;

namespace DevopsAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee() { EmployeeId = 1005, EmployeeFName = "Scott",Job = "Manager"},
                new Employee() { EmployeeId = 1006, EmployeeFName = "Smith",Job = "Lead"},
                new Employee() { EmployeeId = 1007, EmployeeFName = "Sandy",Job = "Programmerr"},
                new Employee() { EmployeeId = 1008, EmployeeFName = "Sam",Job = "Lead"}
            };

            return empList;
        }
            [HttpGet("{id}")]

            public Employee GetEmployeeById(int id)
            {
                List<Employee> empList = new List<Employee>()
            {
                new Employee() { EmployeeId = 1005, EmployeeFName = "Scott",Job = "Manager"},
                new Employee() { EmployeeId = 1006, EmployeeFName = "Smith",Job = "Lead"},
                new Employee() { EmployeeId = 1007, EmployeeFName = "Sandy",Job = "Programmerr"},
                new Employee() { EmployeeId = 1008, EmployeeFName = "Sam",Job = "Lead"}
            };
                Employee obj = empList.SingleOrDefault(item => item.EmployeeId == id);
                return obj;



            }
    }
}
