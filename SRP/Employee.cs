using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // Employee class responsible for representing an employee
    internal class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        // Methods related to the employee's responsibilities
        public void PerformTask(string task)
        {
            Console.WriteLine($"{Name} is performing task: {task}");
        }

        public void AttendMeeting(string meeting)
        {
            Console.WriteLine($"{Name} is attending meeting: {meeting}");
        }
    }
}
