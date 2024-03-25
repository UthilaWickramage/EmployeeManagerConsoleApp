using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerConsoleApp
{
    public class EmployeeRepository
    {
        List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>();
        }
        public void SaveEmployee(Employee employee)
        {
            employees.Add(employee);

        }
    }
}
