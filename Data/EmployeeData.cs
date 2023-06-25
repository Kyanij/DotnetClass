using myAPIproject.Model;
using System.Collections.Generic;

namespace myAPIproject.Data
{
    public class EmployeeData
    {
        public List<Employee> Employees { get; set; }
       
    public static List<Employee> EmployeeList()
        {

            var empList = new List<Employee>()
                    {
                        new Employee() {Id = 1, Address = "KTM"},
                        
                    };

            return empList;


        }

    }
}
