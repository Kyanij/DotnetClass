using Microsoft.AspNetCore.Mvc;
using myAPIproject.Data;
using myAPIproject.Model;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAPIproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>() // List to store employees
        {
            new Employee() { Id = 1, FirstName = "Ram", Address = "KTM", Title = "Engineer"},
            new Employee() { Id = 2, FirstName = "asdf", Address = "KTM"},

        };

        // GET: api/<EmployeeController>
        [HttpGet]
        public List<Employee> GetAllEmployee()
        {

            return employees;

        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee GetAllEmployee(int id)
        {
            
            return employees.Find(emp =>emp.Id == id );

        }
       

        // POST api/<EmployeeController>
        [HttpPost]
        public void CreateEmployee([FromBody] Employee emp)
        {

            //employees.ForEach(e =>
            //{
            //    if (e.Id != emp.Id) employees.Add(emp);
            //});

            var e1 = employees.Any(e => e.Id == emp.Id);

            if (!e1)
            {
                employees.Add(emp);
            }

            
            //foreach(var e in employees)
            //{
            //    if (e.Id != emp.Id)
            //    {
            //        employees.Add(emp);

            //    }
            //}

        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void UpdateEmployee(int id, [FromBody] Employee e)
        {
            var emp = employees.Find(x => x.Id == id);
            if (emp != null)
            {
                emp.FirstName = e.FirstName;
                emp.LastName = e.LastName;
                emp.Title = e.Title;
                emp.Address = e.Address;
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void DeleteEmployee(int id)
        {
            var empToDel = employees.FirstOrDefault(x => x.Id == id);
            if (empToDel != null)
            {
                employees.Remove(empToDel);
            }
        }
    }
}
