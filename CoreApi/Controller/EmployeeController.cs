using CoreApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IList<Employee> employees = new List<Employee>()
        {
            new Employee()
                {
                    EmployeeId = 1, EmployeeName = "Riya Sankesara", Address = "Kalol", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 2, EmployeeName = "Rashmin Mevada", Address = "Visnagar", Department = "HR"
                },
                new Employee()
                {
                    EmployeeId = 3, EmployeeName = "Dhaval Mistry", Address = "Ahmedabad", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 4, EmployeeName = "Disha Tamboli", Address = "Himmatnagar", Department = "Sales"
                },
                new Employee()
                {
                    EmployeeId = 5, EmployeeName = "Vibha Shah", Address = "Rajsthan", Department = "HR"
                },
        };
        [HttpGet]
        [Route("GetAllEmployees")]
        public IList<Employee> GetAllEmployees()
        {
            //Return list of all employees
            return employees;
        }
        [HttpGet]
        [Route("GetEmployeeDetails")]
        public Employee GetEmployeeDetails(int id)
        {
            //Return a single employee detail
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                return new Employee();
            }
            return employee;
        }

    }
}
