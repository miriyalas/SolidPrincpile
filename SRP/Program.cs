// See https://aka.ms/new-console-template for more information
using SRP;

Console.WriteLine("Hello, World!");


Employee employee = new Employee()
{
    Name = "John Doe",
    Department = "Engineering",
    Salary = 5000
};

EmployeeDataService dataService = new EmployeeDataService();
dataService.SaveEmployeeData(employee);
dataService.LoadEmployeeData(employee);
employee.PerformTask("Implement feature");
employee.AttendMeeting("Project kick-off");



