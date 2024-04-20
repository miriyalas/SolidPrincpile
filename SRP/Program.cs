// See https://aka.ms/new-console-template for more information
using SRP;

Employee employee = new Employee()
{
    Name = "Sandeep  Miriyala",
    Department = "IT enginner",
    Salary = 5000
};

EmployeeDataService dataService = new EmployeeDataService();
dataService.SaveEmployeeData(employee);
dataService.LoadEmployeeData(employee);
employee.PerformTask("Implementation");
employee.AttendMeeting("Appriasail FE");



