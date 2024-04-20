using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class EmployeeDataService
    {
        public void SaveEmployeeData(Employee employee)
        {
            // Logic to save employee data to a database or file
            Console.WriteLine($"Saving employee data: {employee.Name}, {employee.Department}, {employee.Salary}");
        }

        public void LoadEmployeeData(Employee employee)
        {
            // Logic to load employee data from a database or file
            Console.WriteLine($"Loading employee data: {employee.Name}");
        }
    }
}
